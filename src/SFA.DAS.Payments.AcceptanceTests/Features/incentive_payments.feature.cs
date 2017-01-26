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
    [NUnit.Framework.DescriptionAttribute("1 learner aged 16-18, levy available, earns incentives")]
    public partial class _1LearnerAged16_18LevyAvailableEarnsIncentivesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "incentive_payments.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "1 learner aged 16-18, levy available, earns incentives", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Payment for a 16-18 DAS learner, levy available, incentives earned")]
        public virtual void PaymentForA16_18DASLearnerLevyAvailableIncentivesEarned()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Payment for a 16-18 DAS learner, levy available, incentives earned", ((string[])(null)));
#line 3
   this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table76 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "price effective date",
                        "planned end date",
                        "agreed price",
                        "status"});
            table76.AddRow(new string[] {
                        "learner a",
                        "01/08/2017",
                        "01/08/2018",
                        "15000",
                        "active"});
#line 6
    testRunner.And("the following commitments exist:", ((string)(null)), table76, "And ");
#line hidden
            TechTalk.SpecFlow.Table table77 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table77.AddRow(new string[] {
                        "learner a",
                        "16-18 programme only DAS",
                        "15000",
                        "06/08/2017",
                        "08/08/2018",
                        "",
                        "continuing"});
#line 10
 testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table77, "When ");
#line hidden
            TechTalk.SpecFlow.Table table78 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "...",
                        "08/18",
                        "09/18"});
            table78.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "2000",
                        "1000",
                        "...",
                        "1000",
                        "0"});
            table78.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "1000",
                        "1000",
                        "1000",
                        "2000",
                        "...",
                        "1000",
                        "1000"});
            table78.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "0"});
            table78.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "0",
                        "0"});
            table78.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table78.AddRow(new string[] {
                        "SFA Levy additional payments budget",
                        "0",
                        "0",
                        "0",
                        "1000",
                        "0",
                        "...",
                        "1000",
                        "0"});
#line 14
    testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table78, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table79 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "...",
                        "08/18",
                        "09/18"});
            table79.AddRow(new string[] {
                        "On-program",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "0"});
            table79.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table79.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table79.AddRow(new string[] {
                        "Employer 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "500",
                        "...",
                        "0",
                        "500"});
            table79.AddRow(new string[] {
                        "Provider 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "500",
                        "...",
                        "0",
                        "500"});
#line 23
    testRunner.And("the transaction types for the payments are:", ((string)(null)), table79, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Payment for a 16-18 DAS learner, levy available, incentives not paid as data lock" +
            " fails")]
        public virtual void PaymentForA16_18DASLearnerLevyAvailableIncentivesNotPaidAsDataLockFails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Payment for a 16-18 DAS learner, levy available, incentives not paid as data lock" +
                    " fails", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 34
    testRunner.Given("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table80 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment number",
                        "ULN",
                        "price effective date",
                        "planned end date",
                        "agreed price",
                        "status"});
            table80.AddRow(new string[] {
                        "1",
                        "learner a",
                        "01/09/2017",
                        "01/09/2018",
                        "15000",
                        "active"});
#line 35
    testRunner.And("the following commitments exist:", ((string)(null)), table80, "And ");
#line hidden
            TechTalk.SpecFlow.Table table81 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table81.AddRow(new string[] {
                        "learner a",
                        "16-18 programme only DAS",
                        "15000",
                        "28/08/2017",
                        "29/08/2018",
                        "",
                        "continuing"});
#line 39
     testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table81, "When ");
#line hidden
            TechTalk.SpecFlow.Table table82 = new TechTalk.SpecFlow.Table(new string[] {
                        "type",
                        "08/17 onwards"});
            table82.AddRow(new string[] {
                        "matching commitment",
                        ""});
#line 43
    testRunner.Then("the data lock status will be as follows:", ((string)(null)), table82, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table83 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "...",
                        "08/18",
                        "09/18"});
            table83.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "2000",
                        "1000",
                        "...",
                        "1000",
                        "0"});
            table83.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table83.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table83.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table83.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table83.AddRow(new string[] {
                        "SFA Levy additional payments budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
#line 47
 testRunner.And("the provider earnings and payments break down as follows:", ((string)(null)), table83, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
