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
using static Google.Ads.GoogleAds.V9.Enums.UserListMembershipStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.UserListPrepopulationStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.UserListStringRuleItemOperatorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example creates a rule-based user list defined by an expression rule for users who
    /// have visited two different sections of a website.
    /// </summary>
    public class AddExpressionRuleUserList : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddExpressionRuleUserList"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID to which the new user list will be added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID to which the new user list will be added.")]
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
                    // The Google Ads customer ID to which the new user list will be added.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            AddExpressionRuleUserList codeExample = new AddExpressionRuleUserList();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a rule-based user list defined by an expression rule for " +
            "users who have visited two different sections of a website.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID to which the new user list will be
        ///     added.</param>
        // [START add_expression_rule_user_list]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Gets the UserListService.
            UserListServiceClient userListServiceClient =
                client.GetService(Services.V9.UserListService);

            // Creates the user targeting rules for each URL.
            UserListRuleItemInfo rule1 = BuildVisitedSiteRuleInfo("example.com/section1");
            UserListRuleItemInfo rule2 = BuildVisitedSiteRuleInfo("example.com/section2");

            // Combine the two rule items into a UserListRuleItemGroupInfo object so Google Ads will
            // AND their rules together. To instead OR the rules together, each rule should be
            // placed in its own rule item group.
            UserListRuleItemGroupInfo userListRuleItemGroupInfo = new UserListRuleItemGroupInfo();
            userListRuleItemGroupInfo.RuleItems.Add(rule1);
            userListRuleItemGroupInfo.RuleItems.Add(rule2);

            UserListRuleInfo userListRuleInfo = new UserListRuleInfo();
            userListRuleInfo.RuleItemGroups.Add(userListRuleItemGroupInfo);

            // Creates an ExpressionRuleUserListInfo object, or a boolean rule that defines this
            // user list. The default rule_type for a UserListRuleInfo object is OR of ANDs
            // (disjunctive normal form). That is, rule items will be ANDed together within rule
            // item groups and the groups themselves will be ORed together.
            ExpressionRuleUserListInfo expressionRuleUserListInfo = new ExpressionRuleUserListInfo
            {
                Rule = userListRuleInfo
            };

            // Defines a representation of a user list that is generated by a rule.
            RuleBasedUserListInfo ruleBasedUserListInfo = new RuleBasedUserListInfo
            {
                // Optional: To include past users in the user list, set the prepopulation_status to
                // REQUESTED.
                PrepopulationStatus = UserListPrepopulationStatus.Requested,
                ExpressionRuleUserList = expressionRuleUserListInfo
            };

            // Creates a new user list.
            UserList userList = new UserList
            {
                Name = "All visitors to example.com/section1 AND example.com/section2 " +
                       $"#{ExampleUtilities.GetRandomString()}",
                Description = "Visitors of both example.com/section1 AND example.com/section2",
                MembershipStatus = UserListMembershipStatus.Open,
                MembershipLifeSpan = 365L,
                RuleBasedUserList = ruleBasedUserListInfo
            };

            // Creates the operation.
            UserListOperation operation = new UserListOperation()
            {
                Create = userList
            };

            try
            {
                // Adds the user list.
                MutateUserListsResponse response = userListServiceClient.MutateUserLists
                    (customerId.ToString(), new[] { operation });

                // Displays the results.
                Console.WriteLine("Created new user list with resource name: " +
                                  $"'{response.Results.First().ResourceName}'.");
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
        /// Creates and returns a UserListRuleItemInfo object targeting a visit to a specified URL.
        /// </summary>
        /// <param name="url">The URL at which the rule will target users.</param>
        /// <returns>A populated UserListRuleItemInfo object.</returns>
        private UserListRuleItemInfo BuildVisitedSiteRuleInfo(string url)
        {
            // Creates a rule targeting any user that visited the specified URL.
            UserListRuleItemInfo userVisitedSiteRule = new UserListRuleItemInfo
            {
                // Uses a built-in parameter to create a domain URL rule.
                Name = "url__",
                StringRuleItem = new UserListStringRuleItemInfo
                {
                    Operator = UserListStringRuleItemOperator.Contains,
                    Value = url
                }
            };

            return userVisitedSiteRule;
        }
        // [END add_expression_rule_user_list]
    }
}
