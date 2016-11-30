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
    [NUnit.Framework.DescriptionAttribute("Datalock validation fails for different reasons")]
    public partial class DatalockValidationFailsForDifferentReasonsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "datalock_errors.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "Datalock validation fails for different reasons", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("When no matching record found in an employer digital account for the UKPRN then d" +
            "atalock DLOCK_01 will be produced")]
        public virtual void WhenNoMatchingRecordFoundInAnEmployerDigitalAccountForTheUKPRNThenDatalockDLOCK_01WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no matching record found in an employer digital account for the UKPRN then d" +
                    "atalock DLOCK_01 will be produced", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "standard code",
                        "agreed price",
                        "start date"});
            table1.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 5
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "standard code",
                        "agreed price",
                        "start date"});
            table2.AddRow(new string[] {
                        "1000000",
                        "1234",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 10
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table2, "When ");
#line 15
    testRunner.Then("a datalock error DLOCK_01 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When no matching record found in an employer digital account for the ULN then dat" +
            "alock DLOCK_02 will be produced")]
        public virtual void WhenNoMatchingRecordFoundInAnEmployerDigitalAccountForTheULNThenDatalockDLOCK_02WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no matching record found in an employer digital account for the ULN then dat" +
                    "alock DLOCK_02 will be produced", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "standard code",
                        "agreed price",
                        "start date"});
            table3.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 19
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "standard code",
                        "agreed price",
                        "start date"});
            table4.AddRow(new string[] {
                        "9999999",
                        "3456",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 24
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table4, "When ");
#line 29
    testRunner.Then("a datalock error DLOCK_02 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When no matching record found in an employer digital account for the standard cod" +
            "e then datalock DLOCK_03 will be produced")]
        public virtual void WhenNoMatchingRecordFoundInAnEmployerDigitalAccountForTheStandardCodeThenDatalockDLOCK_03WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no matching record found in an employer digital account for the standard cod" +
                    "e then datalock DLOCK_03 will be produced", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "standard code",
                        "agreed price",
                        "start date"});
            table5.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 33
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "standard code",
                        "agreed price",
                        "start date"});
            table6.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "2",
                        "10000",
                        "01/05/2017"});
#line 38
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table6, "When ");
#line 43
    testRunner.Then("a datalock error DLOCK_03 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When no matching record found in an employer digital account for the framework co" +
            "de then datalock DLOCK_04 will be produced")]
        public virtual void WhenNoMatchingRecordFoundInAnEmployerDigitalAccountForTheFrameworkCodeThenDatalockDLOCK_04WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no matching record found in an employer digital account for the framework co" +
                    "de then datalock DLOCK_04 will be produced", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table7.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 49
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table8.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "451",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 54
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table8, "When ");
#line 59
    testRunner.Then("a datalock error DLOCK_04 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When no matching record found in an employer digital account for the programme ty" +
            "pe then datalock DLOCK_05 will be produced")]
        public virtual void WhenNoMatchingRecordFoundInAnEmployerDigitalAccountForTheProgrammeTypeThenDatalockDLOCK_05WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no matching record found in an employer digital account for the programme ty" +
                    "pe then datalock DLOCK_05 will be produced", ((string[])(null)));
#line 62
 this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table9.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 64
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table9, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table10.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "3",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 69
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table10, "When ");
#line 74
    testRunner.Then("a datalock error DLOCK_05 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When no matching record found in an employer digital account for the pathway code" +
            " then datalock DLOCK_06 will be produced")]
        public virtual void WhenNoMatchingRecordFoundInAnEmployerDigitalAccountForThePathwayCodeThenDatalockDLOCK_06WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no matching record found in an employer digital account for the pathway code" +
                    " then datalock DLOCK_06 will be produced", ((string[])(null)));
#line 76
 this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table11.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 78
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table12.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "2",
                        "10000",
                        "01/05/2017"});
#line 83
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table12, "When ");
#line 88
    testRunner.Then("a datalock error DLOCK_06 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When no matching record found in an employer digital account for for the agreed p" +
            "rice then datalock DLOCK_07 will be produced")]
        public virtual void WhenNoMatchingRecordFoundInAnEmployerDigitalAccountForForTheAgreedPriceThenDatalockDLOCK_07WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When no matching record found in an employer digital account for for the agreed p" +
                    "rice then datalock DLOCK_07 will be produced", ((string[])(null)));
#line 91
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table13.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 93
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table14.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10001",
                        "01/05/2017"});
#line 98
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table14, "When ");
#line 103
    testRunner.Then("a datalock error DLOCK_07 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When there is more than one matching commitment in the employer digital account t" +
            "hen datalock DLOCK_08 will be produced")]
        public virtual void WhenThereIsMoreThanOneMatchingCommitmentInTheEmployerDigitalAccountThenDatalockDLOCK_08WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When there is more than one matching commitment in the employer digital account t" +
                    "hen datalock DLOCK_08 will be produced", ((string[])(null)));
#line 107
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table15.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
            table15.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 109
    testRunner.Given("the following commitments exist for an apprentice:", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table16.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 115
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table16, "When ");
#line 120
    testRunner.Then("a datalock error DLOCK_08 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When the start month recorded in the employer digital account is after the start " +
            "month in the ILR then datalock DLOCK_09 will be produced")]
        public virtual void WhenTheStartMonthRecordedInTheEmployerDigitalAccountIsAfterTheStartMonthInTheILRThenDatalockDLOCK_09WillBeProduced()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When the start month recorded in the employer digital account is after the start " +
                    "month in the ILR then datalock DLOCK_09 will be produced", ((string[])(null)));
#line 124
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table17.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "01/05/2017"});
#line 126
    testRunner.Given("the following commitment exists for an apprentice:", ((string)(null)), table17, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "UKPRN",
                        "ULN",
                        "framework code",
                        "programme type",
                        "pathway code",
                        "agreed price",
                        "start date"});
            table18.AddRow(new string[] {
                        "9999999",
                        "1234",
                        "450",
                        "2",
                        "1",
                        "10000",
                        "30/04/2017"});
#line 131
    testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table18, "When ");
#line 136
    testRunner.Then("a datalock error DLOCK_09 is produced", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion