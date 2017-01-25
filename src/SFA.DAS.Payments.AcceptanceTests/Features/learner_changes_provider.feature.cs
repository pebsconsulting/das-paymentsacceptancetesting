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
    [NUnit.Framework.DescriptionAttribute("Apprentice changes provider and there is a gap between commitments")]
    public partial class ApprenticeChangesProviderAndThereIsAGapBetweenCommitmentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "learner_changes_provider.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "Apprentice changes provider and there is a gap between commitments", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Apprentice changes provider but remains with the same employer, and there is a ga" +
            "p between the two learning spells")]
        public virtual void ApprenticeChangesProviderButRemainsWithTheSameEmployerAndThereIsAGapBetweenTheTwoLearningSpells()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Apprentice changes provider but remains with the same employer, and there is a ga" +
                    "p between the two learning spells", ((string[])(null)));
#line 4
    this.ScenarioSetup(scenarioInfo);
#line 6
        testRunner.Given("The learner is programme only DAS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
        testRunner.And("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table93 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment number",
                        "Provider",
                        "ULN",
                        "start date",
                        "planned end date",
                        "agreed price",
                        "status"});
            table93.AddRow(new string[] {
                        "1",
                        "provider a",
                        "learner a",
                        "01/08/2017",
                        "01/08/2018",
                        "7500",
                        "active"});
            table93.AddRow(new string[] {
                        "2",
                        "provider b",
                        "learner a",
                        "01/06/2018",
                        "01/11/2018",
                        "4500",
                        "active"});
#line 8
        testRunner.And("the following commitments exist:", ((string)(null)), table93, "And ");
#line hidden
            TechTalk.SpecFlow.Table table94 = new TechTalk.SpecFlow.Table(new string[] {
                        "Provider",
                        "ULN",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status",
                        "Total training price",
                        "Total training price effective date",
                        "Total assessment price",
                        "Total assessment price effective date"});
            table94.AddRow(new string[] {
                        "provider a",
                        "learner a",
                        "06/08/2017",
                        "08/08/2018",
                        "04/03/2018",
                        "Cancelled",
                        "6000",
                        "06/08/2017",
                        "1500",
                        "06/08/2017"});
            table94.AddRow(new string[] {
                        "provider b",
                        "learner a",
                        "06/06/2018",
                        "20/11/2018",
                        "",
                        "continuing",
                        "3000",
                        "06/06/2018",
                        "1500",
                        "06/06/2018"});
#line 13
  testRunner.When("the providers submit the following ILR files:", ((string)(null)), table94, "When ");
#line hidden
            TechTalk.SpecFlow.Table table95 = new TechTalk.SpecFlow.Table(new string[] {
                        "type",
                        "08/17 - 02/17",
                        "04/17 onwards"});
            table95.AddRow(new string[] {
                        "matching commitment",
                        "1",
                        "2"});
#line 19
        testRunner.Then("the data lock status will be as follows:", ((string)(null)), table95, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table96 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "...",
                        "02/18",
                        "03/18"});
            table96.AddRow(new string[] {
                        "Provider Earned Total",
                        "500",
                        "500",
                        "500",
                        "...",
                        "500",
                        "0"});
            table96.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "500",
                        "500",
                        "500",
                        "...",
                        "500",
                        "0"});
            table96.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table96.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "500",
                        "500",
                        "...",
                        "500",
                        "500"});
            table96.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table96.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "500",
                        "500",
                        "...",
                        "500",
                        "500"});
            table96.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "500",
                        "500",
                        "500",
                        "...",
                        "500",
                        "0"});
            table96.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
            table96.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0"});
#line 23
        testRunner.And("the earnings and payments break down for provider a is as follows:", ((string)(null)), table96, "And ");
#line hidden
            TechTalk.SpecFlow.Table table97 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "06/18",
                        "07/18",
                        "08/17",
                        "09/18",
                        "10/18",
                        "11/18"});
            table97.AddRow(new string[] {
                        "Provider Earned Total",
                        "720",
                        "720",
                        "720",
                        "720",
                        "720",
                        "0"});
            table97.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "720",
                        "720",
                        "720",
                        "720",
                        "720",
                        "0"});
            table97.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table97.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "720",
                        "720",
                        "720",
                        "720",
                        "720"});
            table97.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table97.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "720",
                        "720",
                        "720",
                        "720",
                        "720"});
            table97.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "720",
                        "720",
                        "720",
                        "720",
                        "720",
                        "0"});
            table97.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table97.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 35
        testRunner.And("the earnings and payments break down for provider b is as follows:", ((string)(null)), table97, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
