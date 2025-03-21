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
using Google.Ads.GoogleAds.V9.Common;
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V9.Enums.AdCustomizerPlaceholderFieldEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.FeedAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example adds an ad customizer feed and associates it with the customer.
    /// Then it adds an ad that uses the feed to populate dynamic data.
    /// </summary>
    public class AddAdCustomizer : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddAdCustomizer"/> example.
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
            /// ID of the ad groups to which ad customizers are added.
            /// </summary>
            [Option("adGroupIds", Required = true, HelpText =
                "ID of the ad groups to which ad customizers are added.")]
            public IEnumerable<long> AdGroupIds { get; set; }
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

                    // ID of the ad groups to which ad customizers are added.
                    // Add more items to the array as desired.
                    options.AdGroupIds = new long[]
                    {
                        long.Parse("INSERT_AD_GROUP_ID_HERE"),
                        long.Parse("INSERT_AD_GROUP_ID_HERE"),
                    };

                    return 0;
                });

            AddAdCustomizer codeExample = new AddAdCustomizer();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.AdGroupIds.ToArray());
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds an ad customizer feed and associates it with the customer. " +
            "Then it adds an ad that uses the feed to populate dynamic data.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupIds">ID of the ad groups to which ad customizers are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long[] adGroupIds)
        {
            // Get the AdGroupBidModifierService.
            AdGroupBidModifierServiceClient adGroupBidModifierService =
                client.GetService(Services.V9.AdGroupBidModifierService);

            string feedName = "Ad_Customizer_example_feed_" +
                ExampleUtilities.GetShortRandomString();

            try
            {
                // Create a feed to be used as the ad customizer.
                string adCustomizerFeedResourceName =
                    CreateAdCustomizerFeed(client, customerId, feedName);

                // Retrieve the attributes for the newly created feed.
                Dictionary<string, FeedAttribute> adCustomizerFeedAttributes =
                    GetFeedAttributes(client, customerId, adCustomizerFeedResourceName);

                // Map the feed to the ad customizer placeholder type to mark it as an
                // ad customizer.
                CreateAdCustomizerMapping(client, customerId, adCustomizerFeedResourceName,
                    adCustomizerFeedAttributes);

                // Create the feed items that will fill the placeholders in the ads customized by
                // the feed.
                List<string> feedItemResourceNames = CreateFeedItems(client, customerId,
                    adCustomizerFeedResourceName, adCustomizerFeedAttributes);

                // Create a feed item targeting to associate the feed items with specific
                // ad groups to prevent them from being used in other ways.
                CreateFeedItemTargets(client, customerId, adGroupIds, feedItemResourceNames);

                // Create ads with the customizations provided by the feed items.
                CreateAdsWithCustomizations(client, customerId, adGroupIds, feedName);
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
        /// Creates a feed to be used for ad customization.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedName">Name of the feed.</param>
        /// <returns>The resource name of the newly created feed.</returns>
        // [START add_ad_customizer]
        private string CreateAdCustomizerFeed(GoogleAdsClient client, long customerId,
            string feedName)
        {
            // Get the FeedServiceClient.
            FeedServiceClient feedService = client.GetService(Services.V9.FeedService);

            // Creates three feed attributes: a name, a price and a date. The attribute names
            // are arbitrary choices and will be used as placeholders in the ad text fields.
            FeedAttribute nameAttribute = new FeedAttribute()
            {
                Name = "Name",
                Type = FeedAttributeType.String
            };

            FeedAttribute priceAttribute = new FeedAttribute()
            {
                Name = "Price",
                Type = FeedAttributeType.String
            };

            FeedAttribute dateAttribute = new FeedAttribute()
            {
                Name = "Date",
                Type = FeedAttributeType.DateTime
            };

            Feed adCustomizerFeed = new Feed()
            {
                Name = feedName,
                Attributes = { nameAttribute, priceAttribute, dateAttribute }
            };

            FeedOperation feedOperation = new FeedOperation()
            {
                Create = adCustomizerFeed
            };

            MutateFeedsResponse response =
                feedService.MutateFeeds(customerId.ToString(), new[] { feedOperation });

            string feedResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added feed with resource name '{feedResourceName}'.");
            return feedResourceName;
        }
        // [END add_ad_customizer]

        /// <summary>
        ///  Retrieves all the attributes for a feed and returns them in a map using the
        ///  attribute names as keys.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        /// <returns>The attributes of the feed.</returns>
        // [START add_ad_customizer_1]
        private Dictionary<string, FeedAttribute> GetFeedAttributes(GoogleAdsClient client,
                    long customerId, string feedResourceName)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V9.GoogleAdsService);

            string query = $"SELECT feed.attributes, feed.name FROM feed WHERE " +
                $"feed.resource_name = '{feedResourceName}'";

            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            Dictionary<string, FeedAttribute> feedAttributes =
                new Dictionary<string, FeedAttribute>();

            Feed feed = googleAdsService.Search(request).First().Feed;

            Console.WriteLine($"Found the following attributes for feed with name '{feed.Name}'");
            foreach (FeedAttribute feedAttribute in feed.Attributes)
            {
                Console.WriteLine($"\t'{feedAttribute.Name}' with id {feedAttribute.Id} and " +
                    $"type '{feedAttribute.Type}'");
                feedAttributes[feedAttribute.Name] = feedAttribute;
            }
            return feedAttributes;
        }
        // [END add_ad_customizer_1]

        /// <summary>
        /// Creates a feed mapping and sets the feed as an ad customizer feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        /// <param name="feedAttributes">The attributes of the feed.</param>
        // [START add_ad_customizer_2]
        private void CreateAdCustomizerMapping(GoogleAdsClient client, long customerId,
            string feedResourceName, Dictionary<string, FeedAttribute> feedAttributes)
        {
            // Get the FeedMappingService.
            FeedMappingServiceClient feedMappingService =
                client.GetService(Services.V9.FeedMappingService);

            // Map the feed attributes to ad customizer placeholder fields.
            // For a full list of ad customizer placeholder fields, see
            // https://developers.google.com/google-ads/api/reference/rpc/latest/AdCustomizerPlaceholderFieldEnum.AdCustomizerPlaceholderField
            AttributeFieldMapping nameFieldMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes["Name"].Id,
                AdCustomizerField = AdCustomizerPlaceholderField.String
            };

            AttributeFieldMapping priceFieldMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes["Price"].Id,
                AdCustomizerField = AdCustomizerPlaceholderField.Price
            };

            AttributeFieldMapping dateFieldMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes["Date"].Id,
                AdCustomizerField = AdCustomizerPlaceholderField.Date
            };

            FeedMapping feedMapping = new FeedMapping()
            {
                Feed = feedResourceName,
                PlaceholderType = PlaceholderType.AdCustomizer,
                AttributeFieldMappings = { nameFieldMapping, priceFieldMapping, dateFieldMapping }
            };

            FeedMappingOperation operation = new FeedMappingOperation()
            {
                Create = feedMapping
            };

            MutateFeedMappingsResponse response =
                feedMappingService.MutateFeedMappings(customerId.ToString(), new[] { operation });

            Console.WriteLine($"Added feed mapping with resource name" +
                $" '{response.Results[0].ResourceName}'.");
        }
        // [END add_ad_customizer_2]

        /// <summary>
        /// Creates two different feed items to enable two different ad customizations.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        /// <param name="feedAttributes">The attributes of the feed.</param>
        /// <returns>The resource names of the feed items.</returns>
        // [START add_ad_customizer_3]
        private List<string> CreateFeedItems(GoogleAdsClient client, long customerId,
                    string feedResourceName, Dictionary<string, FeedAttribute> feedAttributes)
        {
            // Get the FeedItemServiceClient.
            FeedItemServiceClient feedItemService =
                client.GetService(Services.V9.FeedItemService);

            List<FeedItemOperation> feedItemOperations = new List<FeedItemOperation>();

            DateTime marsDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            feedItemOperations.Add(
                CreateFeedItemOperation("Mars", "$1234.56", marsDate.ToString("yyyyMMdd HHmmss"),
                    feedResourceName, feedAttributes));

            DateTime venusDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
            feedItemOperations.Add(
                CreateFeedItemOperation("Venus", "$1450.00", venusDate.ToString("yyyyMMdd HHmmss"),
                    feedResourceName, feedAttributes));

            List<string> feedItemResourceNames = new List<string>();
            MutateFeedItemsResponse response =
                feedItemService.MutateFeedItems(customerId.ToString(), feedItemOperations);

            Console.WriteLine($"Added {response.Results.Count} feed items:");

            foreach (MutateFeedItemResult result in response.Results)
            {
                string feedItemResourceName = result.ResourceName;
                feedItemResourceNames.Add(feedItemResourceName);
                Console.WriteLine($"Added feed item with resource name '{feedItemResourceName}'.");
            }
            return feedItemResourceNames;
        }
        // [END add_ad_customizer_3]

        /// <summary>
        /// Helper function to create a FeedItemOperation.
        /// </summary>
        /// <param name="name">The value of the Name attribute.</param>
        /// <param name="price">The value of the Price attribute.</param>
        /// <param name="date">The value of the Date attribute.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        /// <param name="feedAttributes">The attributes to be set on the feed.</param>
        /// <returns>A FeedItemOperation to create a feed item.</returns>
        // [START add_ad_customizer_4]
        private FeedItemOperation CreateFeedItemOperation(string name, string price, string date,
            string feedResourceName, Dictionary<string, FeedAttribute> feedAttributes)
        {
            FeedItemAttributeValue nameAttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes["Name"].Id,
                StringValue = name
            };

            FeedItemAttributeValue priceAttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes["Price"].Id,
                StringValue = price
            };

            FeedItemAttributeValue dateAttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes["Date"].Id,
                StringValue = date
            };

            FeedItem feedItem = new FeedItem()
            {
                Feed = feedResourceName,
                AttributeValues = { nameAttributeValue, priceAttributeValue, dateAttributeValue }
            };

            return new FeedItemOperation()
            {
                Create = feedItem
            };
        }
        // [END add_ad_customizer_4]

        /// <summary>
        /// Restricts the feed items to work only with a specific ad group; this prevents the
        /// feed items from being used elsewhere and makes sure they are used only for
        /// customizing a specific ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupIds">The ad group IDs to bind the feed items to..</param>
        /// <param name="feedItemResourceNames">The resource names of the feed items.</param>
        // [START add_ad_customizer_5]
        private void CreateFeedItemTargets(GoogleAdsClient client,
            long customerId, long[] adGroupIds, List<string> feedItemResourceNames)
        {
            // Get the FeedItemTargetServiceClient.
            FeedItemTargetServiceClient feedItemTargetService =
                client.GetService(Services.V9.FeedItemTargetService);

            // Bind each feed item to a specific ad group to make sure it will only be used to
            // customize ads inside that ad group; using the feed item elsewhere will result
            // in an error.
            for (int i = 0; i < feedItemResourceNames.Count; i++)
            {
                string feedItemResourceName = feedItemResourceNames[i];
                long adGroupId = adGroupIds[i];

                FeedItemTarget feedItemTarget = new FeedItemTarget()
                {
                    AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                    FeedItem = feedItemResourceName
                };

                FeedItemTargetOperation feedItemTargetOperation = new FeedItemTargetOperation()
                {
                    Create = feedItemTarget
                };

                MutateFeedItemTargetsResponse response =
                    feedItemTargetService.MutateFeedItemTargets(customerId.ToString(),
                        new[] { feedItemTargetOperation });

                string feedItemTargetResourceName = response.Results[0].ResourceName;
                Console.WriteLine($"Added feed item target with resource name " +
                    $"'{response.Results[0].ResourceName}'.");
            }
        }
        // [END add_ad_customizer_5]

        /// <summary>
        /// Creates expanded text ads that use the ad customizer feed to populate the placeholders.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupIds">The ad group IDs in which to create the ads.</param>
        /// <param name="feedName">Name of the feed.</param>
        // [START add_ad_customizer_6]
        private void CreateAdsWithCustomizations(GoogleAdsClient client, long customerId,
            long[] adGroupIds, string feedName)
        {
            // Get the AdGroupAdServiceClient.
            AdGroupAdServiceClient adGroupAdService =
                client.GetService(Services.V9.AdGroupAdService);

            // Creates an expanded text ad using the feed attribute names as placeholders.
            Ad ad = new Ad()
            {
                ExpandedTextAd = new ExpandedTextAdInfo()
                {
                    HeadlinePart1 = $"Luxury cruise to {{={feedName}.Name}}",
                    HeadlinePart2 = $"Only {{={feedName}.Price}}",
                    Description = $"Offer ends in {{=countdown({feedName}.Date)}}!"
                },
                FinalUrls = { "http://www.example.com" }
            };

            List<AdGroupAdOperation> adGroupAdOperations = new List<AdGroupAdOperation>();

            // Creates the same ad in all ad groups. When they serve, they will show
            // different values, since they match different feed items.
            foreach (long adGroupId in adGroupIds)
            {
                AdGroupAd adGroupAd = new AdGroupAd()
                {
                    Ad = ad,
                    AdGroup = ResourceNames.AdGroup(customerId, adGroupId)
                };

                adGroupAdOperations.Add(new AdGroupAdOperation()
                {
                    Create = adGroupAd
                });
            }

            MutateAdGroupAdsResponse response =
                adGroupAdService.MutateAdGroupAds(customerId.ToString(), adGroupAdOperations);

            Console.WriteLine($"Added {response.Results.Count} ads:");
            foreach (MutateAdGroupAdResult result in response.Results)
            {
                Console.WriteLine($"Added an ad with resource name '{result.ResourceName}'.");
            }
        }
        // [END add_ad_customizer_6]
    }
}
