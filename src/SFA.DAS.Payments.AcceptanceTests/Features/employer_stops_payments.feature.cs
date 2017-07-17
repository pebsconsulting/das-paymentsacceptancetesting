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
    [NUnit.Framework.DescriptionAttribute("Employer stops payments on a commitment")]
    [NUnit.Framework.CategoryAttribute("EmployerStopsPayments")]
    public partial class EmployerStopsPaymentsOnACommitmentFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "employer_stops_payments.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "Employer stops payments on a commitment", null, ProgrammingLanguage.CSharp, new string[] {
                        "EmployerStopsPayments"});
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
        [NUnit.Framework.DescriptionAttribute("Commitment payments are stopped midway through the learning episode")]
        public virtual void CommitmentPaymentsAreStoppedMidwayThroughTheLearningEpisode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Commitment payments are stopped midway through the learning episode", ((string[])(null)));
#line 4
    this.ScenarioSetup(scenarioInfo);
#line 5
        testRunner.Given("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table349 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment Id",
                        "version Id",
                        "ULN",
                        "start date",
                        "end date",
                        "status",
                        "agreed price",
                        "effective from",
                        "effective to"});
            table349.AddRow(new string[] {
                        "1",
                        "1",
                        "learner a",
                        "01/09/2017",
                        "08/09/2018",
                        "active",
                        "15000",
                        "01/09/2017",
                        "31/10/2017"});
            table349.AddRow(new string[] {
                        "1",
                        "2",
                        "learner a",
                        "01/09/2017",
                        "08/09/2018",
                        "paused",
                        "15000",
                        "01/11/2017",
                        ""});
#line 6
        testRunner.And("the following commitments exist:", ((string)(null)), table349, "And ");
#line hidden
            TechTalk.SpecFlow.Table table350 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "agreed price",
                        "learner type",
                        "start date",
                        "planned end date",
                        "completion status"});
            table350.AddRow(new string[] {
                        "learner a",
                        "15000",
                        "programme only DAS",
                        "01/09/2017",
                        "08/09/2018",
                        "continuing"});
#line 10
        testRunner.When("an ILR file is submitted every month with the following data:", ((string)(null)), table350, "When ");
#line hidden
            TechTalk.SpecFlow.Table table351 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "...",
                        "03/18"});
            table351.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "1000"});
            table351.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "1000",
                        "1000",
                        "0",
                        "0",
                        "...",
                        "0"});
            table351.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table351.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "1000",
                        "1000",
                        "0",
                        "...",
                        "0"});
            table351.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table351.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "1000",
                        "1000",
                        "0",
                        "...",
                        "0"});
            table351.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "1000",
                        "1000",
                        "0",
                        "0",
                        "...",
                        "0"});
            table351.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table351.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
#line 13
        testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table351, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The provider submits the first ILR file after the commitment payments have been s" +
            "topped")]
        public virtual void TheProviderSubmitsTheFirstILRFileAfterTheCommitmentPaymentsHaveBeenStopped()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The provider submits the first ILR file after the commitment payments have been s" +
                    "topped", ((string[])(null)));
#line 26
    this.ScenarioSetup(scenarioInfo);
#line 27
        testRunner.Given("levy balance > agreed price for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table352 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment Id",
                        "version Id",
                        "ULN",
                        "start date",
                        "end date",
                        "status",
                        "agreed price",
                        "effective from",
                        "effective to"});
            table352.AddRow(new string[] {
                        "1",
                        "1",
                        "learner a",
                        "01/09/2017",
                        "08/09/2018",
                        "active",
                        "15000",
                        "01/09/2017",
                        "31/08/2017"});
            table352.AddRow(new string[] {
                        "1",
                        "2",
                        "learner a",
                        "01/09/2017",
                        "08/09/2018",
                        "paused",
                        "15000",
                        "01/09/2017",
                        ""});
#line 28
        testRunner.And("the following commitments exist:", ((string)(null)), table352, "And ");
#line hidden
            TechTalk.SpecFlow.Table table353 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "agreed price",
                        "learner type",
                        "start date",
                        "planned end date",
                        "completion status"});
            table353.AddRow(new string[] {
                        "learner a",
                        "15000",
                        "programme only DAS",
                        "01/09/2017",
                        "08/09/2018",
                        "continuing"});
#line 32
        testRunner.When("an ILR file is submitted for the first time on 28/12/17 with the following data:", ((string)(null)), table353, "When ");
#line hidden
            TechTalk.SpecFlow.Table table354 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17",
                        "...",
                        "03/18"});
            table354.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000",
                        "1000",
                        "...",
                        "1000"});
            table354.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table354.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table354.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table354.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table354.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table354.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table354.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
            table354.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0"});
#line 35
        testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table354, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("700_AC01 DAS learner, payments are stopped as the employer has never paid levy")]
        public virtual void _700_AC01DASLearnerPaymentsAreStoppedAsTheEmployerHasNeverPaidLevy()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("700_AC01 DAS learner, payments are stopped as the employer has never paid levy", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 50
        testRunner.Given("the employer is not a levy payer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table355 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment Id",
                        "ULN",
                        "priority",
                        "start date",
                        "end date",
                        "agreed price"});
            table355.AddRow(new string[] {
                        "1",
                        "learner a",
                        "1",
                        "01/08/2017",
                        "01/08/2018",
                        "15000"});
#line 51
  testRunner.And("the following commitments exist:", ((string)(null)), table355, "And ");
#line hidden
            TechTalk.SpecFlow.Table table356 = new TechTalk.SpecFlow.Table(new string[] {
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table356.AddRow(new string[] {
                        "programme only DAS",
                        "15000",
                        "05/08/2017",
                        "20/08/2018",
                        "",
                        "continuing"});
#line 54
  testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table356, "When ");
#line hidden
            TechTalk.SpecFlow.Table table357 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17"});
            table357.AddRow(new string[] {
                        "On-program",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table357.AddRow(new string[] {
                        "Completion",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table357.AddRow(new string[] {
                        "Employer 16-18 incentive",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table357.AddRow(new string[] {
                        "Provider 16-18 incentive",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table357.AddRow(new string[] {
                        "Provider learning support",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table357.AddRow(new string[] {
                        "English and maths on programme",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table357.AddRow(new string[] {
                        "English and maths Balancing",
                        "",
                        "",
                        "",
                        "",
                        ""});
#line 57
  testRunner.Then("the data lock status will be as follows:", ((string)(null)), table357, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table358 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17"});
            table358.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000"});
            table358.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "0",
                        "0",
                        "0"});
            table358.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "0",
                        "0"});
            table358.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0"});
            table358.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0"});
            table358.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0"});
#line 67
  testRunner.And("the provider earnings and payments break down as follows:", ((string)(null)), table358, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("700_AC02 DAS learner, payments are allowed as the employer has previously paid le" +
            "vy")]
        public virtual void _700_AC02DASLearnerPaymentsAreAllowedAsTheEmployerHasPreviouslyPaidLevy()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("700_AC02 DAS learner, payments are allowed as the employer has previously paid le" +
                    "vy", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 79
        testRunner.Given("levy balance = 0 for all months", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table359 = new TechTalk.SpecFlow.Table(new string[] {
                        "commitment Id",
                        "version Id",
                        "ULN",
                        "priority",
                        "start date",
                        "end date",
                        "agreed price"});
            table359.AddRow(new string[] {
                        "1",
                        "1-001",
                        "learner a",
                        "1",
                        "01/08/2017",
                        "01/08/2018",
                        "15000"});
#line 80
  testRunner.And("the following commitments exist:", ((string)(null)), table359, "And ");
#line hidden
            TechTalk.SpecFlow.Table table360 = new TechTalk.SpecFlow.Table(new string[] {
                        "learner type",
                        "agreed price",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table360.AddRow(new string[] {
                        "programme only DAS",
                        "15000",
                        "05/08/2017",
                        "20/08/2018",
                        "",
                        "continuing"});
#line 84
        testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table360, "When ");
#line hidden
            TechTalk.SpecFlow.Table table361 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "11/17",
                        "12/17"});
            table361.AddRow(new string[] {
                        "On-program",
                        "commitment 1 v1-001",
                        "commitment 1 v1-001",
                        "commitment 1 v1-001",
                        "commitment 1 v1-001",
                        "commitment 1 v1-001"});
            table361.AddRow(new string[] {
                        "Completion",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table361.AddRow(new string[] {
                        "Employer 16-18 incentive",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table361.AddRow(new string[] {
                        "Provider 16-18 incentive",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table361.AddRow(new string[] {
                        "Provider learning support",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table361.AddRow(new string[] {
                        "English and maths on programme",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table361.AddRow(new string[] {
                        "English and maths Balancing",
                        "",
                        "",
                        "",
                        "",
                        ""});
#line 88
  testRunner.Then("the data lock status will be as follows:", ((string)(null)), table361, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table362 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17"});
            table362.AddRow(new string[] {
                        "Provider Earned Total",
                        "1000",
                        "1000",
                        "1000"});
            table362.AddRow(new string[] {
                        "Provider Earned from SFA",
                        "900",
                        "900",
                        "900"});
            table362.AddRow(new string[] {
                        "Provider Earned from Employer",
                        "100",
                        "100",
                        "100"});
            table362.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "900",
                        "900"});
            table362.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "100",
                        "100"});
            table362.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0"});
            table362.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0"});
            table362.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "900",
                        "900",
                        "900"});
#line 98
  testRunner.And("the provider earnings and payments break down as follows:", ((string)(null)), table362, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
