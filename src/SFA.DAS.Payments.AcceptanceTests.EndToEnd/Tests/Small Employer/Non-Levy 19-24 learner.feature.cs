﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.DAS.Payments.AcceptanceTests.EndToEnd.Tests.SmallEmployer
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Non-Levy 19-24 learner")]
    public partial class Non_Levy19_24LearnerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Non-Levy 19-24 learner.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Non-Levy 19-24 learner", @"	As a provider,
	I want a non-levy learner, 1 learner aged 19-24, employed with a small employer at start, is co-funded for on programme and completion payments (this apprentice does not have a Education Health Care plan and is not a care leaver), to be paid the correct amount
	So that I am accurately paid my apprenticeship provision.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Non-levy learner 19-24 not a care leaver or with EHC plan employed with a small e" +
            "mployer is co-funded PV2-330")]
        public virtual void Non_LevyLearner19_24NotACareLeaverOrWithEHCPlanEmployedWithASmallEmployerIsCo_FundedPV2_330()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Non-levy learner 19-24 not a care leaver or with EHC plan employed with a small e" +
                    "mployer is co-funded PV2-330", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Start Date",
                        "Planned Duration",
                        "Total Training Price",
                        "Total Training Price Effective Date",
                        "Total Assessment Price",
                        "Total Assessment Price Effective Date",
                        "Actual Duration",
                        "Completion Status",
                        "Contract Type",
                        "Aim Sequence Number",
                        "Aim Reference",
                        "Framework Code",
                        "Pathway Code",
                        "Programme Type",
                        "Funding Line Type",
                        "SFA Contribution Percentage"});
            table1.AddRow(new string[] {
                        "06/Aug/Last Academic Year",
                        "12 months",
                        "7500",
                        "06/Aug/Last Academic Year",
                        "0",
                        "06/Aug/Last Academic Year",
                        "",
                        "continuing",
                        "Act2",
                        "1",
                        "ZPROG001",
                        "403",
                        "1",
                        "25",
                        "19-24 Apprenticeship (From May 2017) Non-Levy Contract (non-procured)",
                        "90%"});
#line 11
 testRunner.Given("the provider previously submitted the following learner details", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Delivery Period",
                        "On-Programme",
                        "Completion",
                        "Balancing"});
            table2.AddRow(new string[] {
                        "Aug/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Sep/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Oct/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Nov/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Dec/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Jan/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Feb/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Mar/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Apr/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "May/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Jun/Last Academic Year",
                        "500",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Jul/Last Academic Year",
                        "500",
                        "0",
                        "0"});
#line 14
    testRunner.And("the following earnings had been generated for the learner", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "SFA Co-Funded Payments",
                        "Employer Co-Funded Payments",
                        "Transaction Type"});
            table3.AddRow(new string[] {
                        "R01/Last Academic Year",
                        "Jul/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R02/Last Academic Year",
                        "Aug/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R03/Last Academic Year",
                        "Sep/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R04/Last Academic Year",
                        "Oct/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R05/Last Academic Year",
                        "Nov/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R06/Last Academic Year",
                        "Dec/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R07/Last Academic Year",
                        "Jan/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R08/Last Academic Year",
                        "Feb/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R09/Last Academic Year",
                        "Mar/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R10/Last Academic Year",
                        "Apr/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R11/Last Academic Year",
                        "May/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
            table3.AddRow(new string[] {
                        "R12/Last Academic Year",
                        "Jun/Last Academic Year",
                        "450",
                        "50",
                        "Learning"});
#line 29
    testRunner.And("the following provider payments had been generated", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Start Date",
                        "Planned Duration",
                        "Total Training Price",
                        "Total Training Price Effective Date",
                        "Total Assessment Price",
                        "Total Assessment Price Effective Date",
                        "Actual Duration",
                        "Completion Status",
                        "Contract Type",
                        "Aim Sequence Number",
                        "Aim Reference",
                        "Framework Code",
                        "Pathway Code",
                        "Programme Type",
                        "Funding Line Type",
                        "SFA Contribution Percentage"});
            table4.AddRow(new string[] {
                        "06/Aug/Last Academic Year",
                        "12 months",
                        "7500",
                        "06/Aug/Last Academic Year",
                        "0",
                        "06/Aug/Last Academic Year",
                        "12 months",
                        "completed",
                        "Act2",
                        "1",
                        "ZPROG001",
                        "403",
                        "1",
                        "25",
                        "19-24 Apprenticeship (From May 2017) Non-Levy Contract (non-procured)",
                        "90%"});
#line 43
    testRunner.But("the Provider now changes the Learner details as follows", ((string)(null)), table4, "But ");
#line 46
 testRunner.When("the amended ILR file is re-submitted for the learners in collection period R01/Cu" +
                    "rrent Academic Year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Delivery Period",
                        "On-Programme",
                        "Completion",
                        "Balancing"});
            table5.AddRow(new string[] {
                        "Aug/Current Academic Year",
                        "0",
                        "1500",
                        "0"});
            table5.AddRow(new string[] {
                        "Sep/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Oct/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Nov/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Dec/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Jan/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Feb/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Mar/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Apr/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "May/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Jun/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table5.AddRow(new string[] {
                        "Jul/Current Academic Year",
                        "0",
                        "0",
                        "0"});
#line 47
 testRunner.Then("the following learner earnings should be generated", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "On-Programme",
                        "Completion",
                        "Balancing"});
            table6.AddRow(new string[] {
                        "R01/Current Academic Year",
                        "Aug/Current Academic Year",
                        "0",
                        "1500",
                        "0"});
#line 61
    testRunner.And("only the following payments will be calculated", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "SFA Co-Funded Payments",
                        "Employer Co-Funded Payments",
                        "Transaction Type"});
            table7.AddRow(new string[] {
                        "R01/Current Academic Year",
                        "Aug/Current Academic Year",
                        "1350",
                        "150",
                        "Completion"});
#line 64
 testRunner.And("only the following provider payments will be recorded", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "SFA Co-Funded Payments",
                        "Employer Co-Funded Payments",
                        "Transaction Type"});
            table8.AddRow(new string[] {
                        "R01/Current Academic Year",
                        "Aug/Current Academic Year",
                        "1350",
                        "150",
                        "Completion"});
#line 67
 testRunner.And("at month end only the following provider payments will be generated", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
