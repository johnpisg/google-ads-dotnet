// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using CommandLine;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example illustrates how to search for language constants by name that
    /// includes the specified keyword. Then it searches for all the available mobile carrier
    /// constants with a given country code.
    /// </summary>
    public class SearchForLanguageAndCarrierConstants : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="SearchForLanguageAndCarrierConstants"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The language name to search for.
            /// </summary>
            [Option("languageName", Required = true, HelpText =
                "The language name to search for.")]
            public string LanguageName { get; set; }

            /// <summary>
            /// The country code to search for carrier code.
            /// </summary>
            [Option("carrierCountryCode", Required = true, HelpText =
                "The country code to search for carrier code.")]
            public string CarrierCountryCode { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The language name to search for.
                    options.LanguageName = "INSERT_LANGUAGE_NAME_HERE";

                    // The country code for which the search is performed.
                    // A list of country codes can be referenced here:
                    // https://developers.google.com/google-ads/api/reference/data/geotargets.
                    options.CarrierCountryCode = "INSERT_CARRIER_COUNTRY_CODE_HERE";

                    return 0;
                });

            SearchForLanguageAndCarrierConstants codeExample =
                new SearchForLanguageAndCarrierConstants();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.LanguageName,
                options.CarrierCountryCode);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates how to search for language constants by name that " +
            "includes the specified keyword. Then it searches for all the available mobile " +
            "carrier constants with a given country code.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="languageName">The language name to search for.</param>
        /// <param name="carrierCountryCode">The country code for which the search is performed.
        /// A list of country codes can be referenced here:
        /// https://developers.google.com/google-ads/api/reference/data/geotargets.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, string languageName,
            string carrierCountryCode)
        {
            try
            {
                SearchTargetableLanguages(client, customerId, languageName);
                SearchTargetableCarriers(client, customerId, carrierCountryCode);
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// Searches the targetable carriers by country code.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="countryCode">The country code.</param>
        private void SearchTargetableCarriers(GoogleAdsClient client, long customerId,
            string countryCode)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V9.GoogleAdsService);

            // Create a query that retrieves the targetable carriers by country code.
            string query = $"SELECT carrier_constant.id, carrier_constant.name, " +
                $"carrier_constant.country_code FROM carrier_constant " +
                $"WHERE carrier_constant.country_code = '{countryCode}'";

            // Issue a search request.
            googleAdsService.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    // Display the results.
                    foreach (GoogleAdsRow criterionRow in resp.Results)
                    {
                        CarrierConstant carrier = criterionRow.CarrierConstant;
                        Console.WriteLine($"Carrier with ID {carrier.Id}, name '{carrier.Name}' " +
                            $"and country code '{carrier.CountryCode}' was found.");
                    }
                });
        }

        /// <summary>
        /// Search for targetable languages by their name.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="languageName">The language name to search for.</param>
        private void SearchTargetableLanguages(GoogleAdsClient client, long customerId,
            string languageName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V9.GoogleAdsService);

            // Create a query that retrieves the language constants by the keyword included
            // in the name.
            string query = $"SELECT language_constant.id, language_constant.code, " +
                $"language_constant.name, language_constant.targetable " +
                $"FROM language_constant " +
                $"WHERE language_constant.name LIKE '%{languageName}%'";

            // Issue a search request.
            googleAdsService.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    foreach (GoogleAdsRow criterionRow in resp.Results)
                    {
                        LanguageConstant language = criterionRow.LanguageConstant;
                        // Display the results.
                        Console.WriteLine($"Language with ID {language.Id}, code " +
                            $"'{language.Code}', name '{language.Name}'and targetable:" +
                            $" '{language.Targetable}' was found.");
                    }
                });
        }
    }
}
