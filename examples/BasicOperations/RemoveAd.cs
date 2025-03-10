// Copyright 2019 Google LLC
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
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example removes an ad. To list ads, run GetExpandedTextAds.cs.
    /// </summary>
    public class RemoveAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="RemoveAd"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The ad group ID that contains the ad.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ad group ID that contains the ad.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// ID of the ad to remove.
            /// </summary>
            [Option("adId", Required = true, HelpText =
                "ID of the ad to remove.")]
            public long AdId { get; set; }
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
                    // The customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The ad group ID that contains the ad.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    // ID of the ad to remove.
                    options.AdId = long.Parse("INSERT_AD_ID_HERE");

                    return 0;
                });

            RemoveAd codeExample = new RemoveAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId,
                options.AdId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example removes an ad. To list ads, run " +
            "GetExpandedTextAds.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID that contains the ad.</param>
        /// <param name="adId">ID of the ad to remove.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long adId)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient service = client.GetService(Services.V9.AdGroupAdService);

            // Create a new operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                // Set the Remove field to the name of the resource to be removed.
                Remove = ResourceNames.AdGroupAd(customerId, adGroupId, adId)
            };

            try
            {
                // Remove the ad.
                MutateAdGroupAdsResponse response = service.MutateAdGroupAds(customerId.ToString(),
                    new AdGroupAdOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine($"Ad with resource name = {result.ResourceName} " +
                        "was removed.");
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
