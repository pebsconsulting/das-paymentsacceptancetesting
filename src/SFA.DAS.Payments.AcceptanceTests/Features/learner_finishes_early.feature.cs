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
    [NUnit.Framework.DescriptionAttribute("Provider earnings and payments where learner completes earlier than planned")]
    public partial class ProviderEarningsAndPaymentsWhereLearnerCompletesEarlierThanPlannedFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "learner_finishes_early.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "Provider earnings and payments where learner completes earlier than planned", "    The earnings and payment rules for early completions are the same as for lear" +
                    "ners finishing on time, except that the completion payment is earned earlier.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 5
    #line 6
        testRunner.Given("the apprenticeship funding band maximum for each learner is 17000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A DAS learner, levy available, learner finishes one month early")]
        public virtual void ADASLearnerLevyAvailableLearnerFinishesOneMonthEarly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A DAS learner, levy available, learner finishes one month early", ((string[])(null)));
#line 8
    this.ScenarioSetup(scenarioInfo);
#line 5
    this.FeatureBackground();
#line 9
        testRunner.Given("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table354 = new TechTalk.SpecFlow.Table(new string[] {
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table354.AddRow(new string[] {
                        "programme only DAS",
                        "15000",
                        "01/09/2017",
                        "08/09/2018",
                        "08/08/2018",
                        "completed"});
#line 10
        testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table354, "When ");
#line hidden
            TechTalk.SpecFlow.Table table355 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "...",
                        "08/18",
                        "09/18"});
            table355.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "4000",
                        "0"});
            table355.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "4000",
                        "0"});
            table355.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "4000"});
            table355.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "4000"});
            table355.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "4000",
                        "0"});
            table355.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
#line 13
        testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table355, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table356 = new TechTalk.SpecFlow.Table(new string[] {
                        "Transaction type",
                        "10/17",
                        "11/17",
                        "...",
                        "08/18",
                        "09/18"});
            table356.AddRow(new string[] {
                        "On-program",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "0"});
            table356.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "...",
                        "0",
                        "3000"});
            table356.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "...",
                        "0",
                        "1000"});
#line 21
        testRunner.And("the transaction types for the payments are:", ((string)(null)), table356, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A DAS learner, levy available, learner finishes two months early")]
        public virtual void ADASLearnerLevyAvailableLearnerFinishesTwoMonthsEarly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A DAS learner, levy available, learner finishes two months early", ((string[])(null)));
#line 27
    this.ScenarioSetup(scenarioInfo);
#line 5
    this.FeatureBackground();
#line 28
        testRunner.Given("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table357 = new TechTalk.SpecFlow.Table(new string[] {
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table357.AddRow(new string[] {
                        "programme only DAS",
                        "15000",
                        "01/09/2017",
                        "08/09/2018",
                        "08/07/2018",
                        "completed"});
#line 29
        testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table357, "When ");
#line hidden
            TechTalk.SpecFlow.Table table358 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "...",
                        "07/18",
                        "08/18"});
            table358.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "5000",
                        "0"});
            table358.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "5000",
                        "0"});
            table358.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "5000"});
            table358.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "5000"});
            table358.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "5000",
                        "0"});
            table358.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
#line 32
        testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table358, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table359 = new TechTalk.SpecFlow.Table(new string[] {
                        "Transaction type",
                        "10/17",
                        "11/17",
                        "...",
                        "07/18",
                        "08/18"});
            table359.AddRow(new string[] {
                        "On-program",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "0"});
            table359.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "...",
                        "0",
                        "3000"});
            table359.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "...",
                        "0",
                        "2000"});
#line 40
        testRunner.And("the transaction types for the payments are:", ((string)(null)), table359, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A non-DAS learner, learner finishes early")]
        public virtual void ANon_DASLearnerLearnerFinishesEarly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A non-DAS learner, learner finishes early", ((string[])(null)));
#line 47
    this.ScenarioSetup(scenarioInfo);
#line 5
    this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table360 = new TechTalk.SpecFlow.Table(new string[] {
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table360.AddRow(new string[] {
                        "programme only non-DAS",
                        "18750",
                        "01/09/2017",
                        "08/12/2018",
                        "08/09/2018",
                        "completed"});
#line 48
        testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table360, "When ");
#line hidden
            TechTalk.SpecFlow.Table table361 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "...",
                        "08/18",
                        "09/18",
                        "10/18"});
            table361.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "1000",
                        "6750",
                        "0"});
            table361.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "900",
                        "900",
                        "900",
                        "...",
                        "900",
                        "6075",
                        "0"});
            table361.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "100",
                        "100",
                        "100",
                        "...",
                        "100",
                        "675",
                        "0"});
            table361.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "900",
                        "900",
                        "...",
                        "900",
                        "900",
                        "6075"});
            table361.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "100",
                        "100",
                        "...",
                        "100",
                        "100",
                        "675"});
            table361.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0"});
            table361.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0"});
            table361.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0"});
            table361.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "900",
                        "900",
                        "900",
                        "...",
                        "900",
                        "6075",
                        "0"});
#line 51
        testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table361, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table362 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "10/17",
                        "11/17",
                        "12/17",
                        "01/18",
                        "...",
                        "09/18",
                        "10/18"});
            table362.AddRow(new string[] {
                        "On-program",
                        "900",
                        "900",
                        "900",
                        "900",
                        "...",
                        "900",
                        "0"});
            table362.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "3375"});
            table362.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "2700"});
            table362.AddRow(new string[] {
                        "Employer 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table362.AddRow(new string[] {
                        "Provider 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
#line 62
        testRunner.And("the transaction types for the payments are:", ((string)(null)), table362, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A non-DAS learner, learner withdraws after qualifying period")]
        public virtual void ANon_DASLearnerLearnerWithdrawsAfterQualifyingPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A non-DAS learner, learner withdraws after qualifying period", ((string[])(null)));
#line 71
    this.ScenarioSetup(scenarioInfo);
#line 5
    this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table363 = new TechTalk.SpecFlow.Table(new string[] {
                        "agreed price",
                        "learner type",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table363.AddRow(new string[] {
                        "15000",
                        "programme only non-DAS",
                        "01/09/2017",
                        "08/09/2018",
                        "08/01/2018",
                        "withdrawn"});
#line 73
        testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table363, "When ");
#line hidden
            TechTalk.SpecFlow.Table table364 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "01/18"});
            table364.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "0"});
            table364.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "900",
                        "900",
                        "900",
                        "900",
                        "0"});
            table364.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "100",
                        "100",
                        "100",
                        "100",
                        "0"});
            table364.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "900",
                        "900",
                        "900",
                        "900"});
            table364.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "100",
                        "100",
                        "100",
                        "100"});
            table364.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table364.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table364.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table364.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "900",
                        "900",
                        "900",
                        "900",
                        "0"});
#line 76
        testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table364, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table365 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "10/17",
                        "11/17",
                        "12/17",
                        "01/18"});
            table365.AddRow(new string[] {
                        "On-program",
                        "900",
                        "900",
                        "900",
                        "900"});
            table365.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "0",
                        "0"});
            table365.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "0",
                        "0"});
            table365.AddRow(new string[] {
                        "Employer 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0"});
            table365.AddRow(new string[] {
                        "Provider 16-18 incentive",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 87
        testRunner.And("the transaction types for the payments are:", ((string)(null)), table365, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
