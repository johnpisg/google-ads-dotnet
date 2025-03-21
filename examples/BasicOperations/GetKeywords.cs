// Copyright 2019 Google LLC.
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
using Google.Ads.GoogleAds.V9.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example illustrates getting keywords.
    /// </summary>
    public class GetKeywords : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetKeywords"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }
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

                    return 0;
                });

            GetKeywords codeExample = new GetKeywords();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example illustrates getting keywords.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V9.GoogleAdsService);
            try
            {
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                  googleAdsService.Search(customerId.ToString(),
                      $@"SELECT
                    ad_group.id,
                    ad_group.status,
                    ad_group_criterion.criterion_id,
                    ad_group_criterion.keyword.text,
                    ad_group_criterion.keyword.match_type
                FROM ad_group_criterion
                WHERE ad_group_criterion.type = 'KEYWORD'
                    AND ad_group.status = 'ENABLED'
                    AND ad_group_criterion.status IN ('ENABLED', 'PAUSED')
                LIMIT 50");
                foreach (GoogleAdsRow criterionRow in result)
                {
                    Console.WriteLine("Keyword with text '{0}', id = '{1}' and match type = " +
                        "'{2}' was retrieved for ad group '{3}'.",
                        criterionRow.AdGroupCriterion.Keyword.Text,
                        criterionRow.AdGroupCriterion.CriterionId,
                        criterionRow.AdGroupCriterion.Keyword.MatchType,
                        criterionRow.AdGroup.Id.ToString());
                }
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
    }
}
