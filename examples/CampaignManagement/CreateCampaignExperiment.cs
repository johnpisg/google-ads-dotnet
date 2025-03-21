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
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V9.Enums.CampaignExperimentTrafficSplitTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example adds a campaign experiment for a draft campaign.
    /// </summary>
    public class CreateCampaignExperiment : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="CreateCampaignExperiment"/> example.
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
            /// ID of the base campaign.
            /// </summary>
            [Option("baseCampaignId", Required = true, HelpText =
                "ID of the base campaign.")]
            public long BaseCampaignId { get; set; }

            /// <summary>
            /// ID of the draft campaign.
            /// </summary>
            [Option("draftId", Required = true, HelpText =
                "ID of the draft campaign.")]
            public long DraftId { get; set; }
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

                    // ID of the base campaign.
                    options.BaseCampaignId = long.Parse("INSERT_BASE_CAMPAIGN_ID_HERE");

                    // ID of the draft campaign.
                    options.DraftId = long.Parse("INSERT_DRAFT_ID_HERE");

                    return 0;
                });

            CreateCampaignExperiment codeExample = new CreateCampaignExperiment();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.BaseCampaignId,
                options.DraftId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a campaign experiment for a draft campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="baseCampaignId">ID of the base campaign.</param>
        /// <param name="draftId">ID of the draft campaign.</param>
        public void Run(GoogleAdsClient client, long customerId, long baseCampaignId, long draftId)
        {
            try
            {
                string campaignDraftResourceName = ResourceNames.CampaignDraft(
                    customerId, baseCampaignId, draftId);
                Operation<Empty, CreateCampaignExperimentMetadata> operation =
                    CreateExperiment(client, customerId, campaignDraftResourceName);

                Console.WriteLine("Waiting until operation completes...");
                operation.PollUntilCompleted();

                DisplayExperimentDetails(client, customerId, operation.Metadata.CampaignExperiment);
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
        /// Creates an experiment.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignDraftResourceName">The resource name Name of the campaign
        /// draft.</param>
        /// <returns>The long running operation for experiment creation.</returns>
        private static Operation<Empty, CreateCampaignExperimentMetadata>
            CreateExperiment(GoogleAdsClient client, long customerId,
                string campaignDraftResourceName)
        {
            // Get the CampaignExperimentService.
            CampaignExperimentServiceClient campaignExperimentService =
                client.GetService(Services.V9.CampaignExperimentService);

            CampaignExperiment experiment = new CampaignExperiment()
            {
                CampaignDraft = campaignDraftResourceName,
                Name = "Campaign Experiment - " + ExampleUtilities.GetRandomString(),
                TrafficSplitPercent = 50,
                TrafficSplitType = CampaignExperimentTrafficSplitType.RandomQuery
            };

            Operation<Empty, CreateCampaignExperimentMetadata> operation =
                campaignExperimentService.CreateCampaignExperiment(
                    customerId.ToString(), experiment);

            string experimentResourceName = operation.Metadata.CampaignExperiment;
            Console.WriteLine($"Created campaign experiment with resource name " +
                $"{experimentResourceName}");

            return operation;
        }

        /// <summary>
        /// Fetches an experiment and display its details.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="experimentResourceName">Resource name of the experiment.</param>
        /// <returns></returns>
        private static void DisplayExperimentDetails(GoogleAdsClient client, long customerId,
            string experimentResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V9.GoogleAdsService);

            // Once the draft is created, you can modify the draft campaign as if it were
            // a real campaign. For example, you may add criteria, adjust bids, or even
            // include additional ads. Adding a criterion is shown here.
            string query = $@"
                SELECT
                    campaign_experiment.experiment_campaign
                FROM
                    campaign_experiment
                WHERE
                    campaign_experiment.resource_name = '{experimentResourceName}'";

            // Get the expriment campaign resource name.
            string experimentCampaignResourceName = googleAdsService.Search(
                customerId.ToString(), query).First().CampaignExperiment.ExperimentCampaign;

            Console.WriteLine($"Experiment campaign with resource ID =" +
                $" '{experimentCampaignResourceName}' finished creating.");
        }
    }
}
