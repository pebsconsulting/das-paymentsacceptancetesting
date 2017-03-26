﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.DAS.Payments.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Provider earnings and payments where learner refund payments are due")]
    [NUnit.Framework.CategoryAttribute("Refunds")]
    public partial class ProviderEarningsAndPaymentsWhereLearnerRefundPaymentsAreDueFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "refunds.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "Provider earnings and payments where learner refund payments are due", null, ProgrammingLanguage.CSharp, new string[] {
                        "Refunds"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("673-AC01 DAS learner, levy available, provider retrospectively notifies a withdra" +
            "wal and previously-paid monthly instalments need to be refunded.")]
        public virtual void _673_AC01DASLearnerLevyAvailableProviderRetrospectivelyNotifiesAWithdrawalAndPreviously_PaidMonthlyInstalmentsNeedToBeRefunded_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("673-AC01 DAS learner, levy available, provider retrospectively notifies a withdra" +
                    "wal and previously-paid monthly instalments need to be refunded.", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
  testRunner.Given("The learner is programme only DAS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.And("the apprenticeship funding band maximum is 17000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
    testRunner.And("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table471 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment Id",
                        "version Id",
                        "ULN",
                        "start date",
                        "end date",
                        "status",
                        "agreed price",
                        "effective from",
                        "effective to"});
            table471.AddRow(new string[] {
                        "1",
                        "1",
                        "learner a",
                        "01/08/2017",
                        "01/08/2018",
                        "active",
                        "11250",
                        "01/08/2017",
                        ""});
#line 8
 testRunner.And("the following commitments exist:", ((string)(null)), table471, "And ");
#line hidden
            TechTalk.SpecFlow.Table table472 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "01/18"});
            table472.AddRow(new string[] {
                        "Provider Earned Total",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750",
                        "0"});
            table472.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750",
                        "0"});
            table472.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table472.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750"});
            table472.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table472.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750"});
            table472.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750",
                        "0"});
            table472.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 12
 testRunner.And("the following earnings and payments have been made to the provider for learner a:" +
                    "", ((string)(null)), table472, "And ");
#line hidden
            TechTalk.SpecFlow.Table table473 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status",
                        "Total training price",
                        "Total training price effective date",
                        "Total assessment price",
                        "Total assessment price effective date"});
            table473.AddRow(new string[] {
                        "learner a",
                        "04/08/2017",
                        "20/08/2018",
                        "12/11/2017",
                        "withdrawn",
                        "9000",
                        "04/08/2017",
                        "2250",
                        "04/08/2017"});
#line 22
 testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table473, "When ");
#line hidden
            TechTalk.SpecFlow.Table table474 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "01/18"});
            table474.AddRow(new string[] {
                        "Provider Earned Total",
                        "750",
                        "750",
                        "750",
                        "0",
                        "0",
                        "0"});
            table474.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "750",
                        "750",
                        "750",
                        "0",
                        "0",
                        "0"});
            table474.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table474.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750"});
            table474.AddRow(new string[] {
                        "Refund taken by SFA",
                        "0",
                        "0",
                        "0",
                        "0",
                        "-750",
                        "-750"});
            table474.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table474.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750"});
            table474.AddRow(new string[] {
                        "Levy account credited",
                        "0",
                        "0",
                        "0",
                        "0",
                        "750",
                        "750"});
            table474.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "750",
                        "750",
                        "750",
                        "0",
                        "0",
                        "0"});
            table474.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 25
 testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table474, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("673-AC03 DAS learner, insufficient levy available to cover full payments, provide" +
            "r retrospectively notifies a withdrawal and previously-paid monthly instalments " +
            "need to be refunded.\tGiven The learner is programme only DAS")]
        public virtual void _673_AC03DASLearnerInsufficientLevyAvailableToCoverFullPaymentsProviderRetrospectivelyNotifiesAWithdrawalAndPreviously_PaidMonthlyInstalmentsNeedToBeRefunded_GivenTheLearnerIsProgrammeOnlyDAS()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("673-AC03 DAS learner, insufficient levy available to cover full payments, provide" +
                    "r retrospectively notifies a withdrawal and previously-paid monthly instalments " +
                    "need to be refunded.\tGiven The learner is programme only DAS", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
    testRunner.And("the apprenticeship funding band maximum is 17000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.And("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table475 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment Id",
                        "version Id",
                        "ULN",
                        "start date",
                        "end date",
                        "status",
                        "agreed price",
                        "effective from",
                        "effective to"});
            table475.AddRow(new string[] {
                        "1",
                        "1",
                        "learner a",
                        "01/08/2017",
                        "01/08/2018",
                        "active",
                        "11250",
                        "01/08/2017",
                        ""});
#line 42
 testRunner.And("the following commitments exist:", ((string)(null)), table475, "And ");
#line hidden
            TechTalk.SpecFlow.Table table476 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "01/18"});
            table476.AddRow(new string[] {
                        "Provider Earned Total",
                        "750",
                        "750",
                        "750",
                        "750",
                        "750",
                        "0"});
            table476.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "725",
                        "725",
                        "725",
                        "725",
                        "725",
                        "0"});
            table476.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "25",
                        "25",
                        "25",
                        "25",
                        "25",
                        "0"});
            table476.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "725",
                        "725",
                        "725",
                        "725",
                        "725"});
            table476.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "25",
                        "25",
                        "25",
                        "25",
                        "25"});
            table476.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "500",
                        "500",
                        "500",
                        "500",
                        "500"});
            table476.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "500",
                        "500",
                        "500",
                        "500",
                        "500",
                        "0"});
            table476.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "225",
                        "225",
                        "225",
                        "225",
                        "225",
                        "0"});
#line 46
 testRunner.And("the following earnings and payments have been made to the provider for learner a:" +
                    "", ((string)(null)), table476, "And ");
#line hidden
            TechTalk.SpecFlow.Table table477 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status",
                        "Total training price",
                        "Total training price effective date",
                        "Total assessment price",
                        "Total assessment price effective date"});
            table477.AddRow(new string[] {
                        "learner a",
                        "04/08/2017",
                        "20/08/2018",
                        "12/11/2017",
                        "withdrawn",
                        "9000",
                        "04/08/2017",
                        "2250",
                        "04/08/2017"});
#line 57
 testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table477, "When ");
#line hidden
            TechTalk.SpecFlow.Table table478 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "01/18"});
            table478.AddRow(new string[] {
                        "Provider Earned Total",
                        "750",
                        "750",
                        "750",
                        "0",
                        "0",
                        "0"});
            table478.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "725",
                        "725",
                        "725",
                        "0",
                        "0",
                        "0"});
            table478.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "25",
                        "25",
                        "25",
                        "0",
                        "0",
                        "0"});
            table478.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "725",
                        "725",
                        "725",
                        "725",
                        "725"});
            table478.AddRow(new string[] {
                        "Refund taken by SFA",
                        "0",
                        "0",
                        "0",
                        "0",
                        "-725",
                        "-725"});
            table478.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "25",
                        "25",
                        "25",
                        "0",
                        "0"});
            table478.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "500",
                        "500",
                        "500",
                        "500",
                        "500"});
            table478.AddRow(new string[] {
                        "Levy account credited",
                        "0",
                        "0",
                        "0",
                        "0",
                        "500",
                        "500"});
            table478.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "500",
                        "500",
                        "500",
                        "0",
                        "0",
                        "0"});
            table478.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "225",
                        "225",
                        "225",
                        "0",
                        "0",
                        "0"});
#line 60
 testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table478, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
