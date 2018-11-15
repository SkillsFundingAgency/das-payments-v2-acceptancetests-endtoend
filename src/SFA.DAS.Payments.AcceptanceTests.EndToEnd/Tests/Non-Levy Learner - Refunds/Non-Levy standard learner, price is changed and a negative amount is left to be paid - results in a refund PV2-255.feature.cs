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
namespace SFA.DAS.Payments.AcceptanceTests.EndToEnd.Tests.Non_LevyLearner_Refunds
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Non-Levy standard learner, price is changed and a negative amount is left to be p" +
        "aid - results in a refund PV2-255")]
    public partial class Non_LevyStandardLearnerPriceIsChangedAndANegativeAmountIsLeftToBePaid_ResultsInARefundPV2_255Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Non-Levy standard learner, price is changed and a negative amount is left to be paid - results in a refund PV2-255.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Non-Levy standard learner, price is changed and a negative amount is left to be p" +
                    "aid - results in a refund PV2-255", "\tAs a Provider\r\n\tI would like TODO\r\n\tSo that TODO", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Non-Levy standard learner, price is changed and a negative amount is left to be p" +
            "aid - results in a refund PV2-255")]
        [NUnit.Framework.TestCaseAttribute("R03/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R04/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R05/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R06/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R07/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R08/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R09/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R10/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R11/Current Academic Year", null)]
        [NUnit.Framework.TestCaseAttribute("R12/Current Academic Year", null)]
        public virtual void Non_LevyStandardLearnerPriceIsChangedAndANegativeAmountIsLeftToBePaid_ResultsInARefundPV2_255(string collection_Period, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Non-Levy standard learner, price is changed and a negative amount is left to be p" +
                    "aid - results in a refund PV2-255", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "Priority",
                        "Start Date",
                        "Planned Duration",
                        "Total Training Price",
                        "Total Training Price Effective Date",
                        "Total Assessment Price",
                        "Total Assessment Price Effective Date",
                        "Actual Duration",
                        "Completion Status",
                        "SFA Contribution Percentage",
                        "Contract Type",
                        "Aim Sequence Number",
                        "Aim Reference",
                        "Framework Code",
                        "Pathway Code",
                        "Programme Type",
                        "Funding Line Type"});
            table1.AddRow(new string[] {
                        "learner a",
                        "1",
                        "start of academic year",
                        "12 months",
                        "9000",
                        "Aug/Current Academic Year",
                        "2250",
                        "Aug/Current Academic Year",
                        "",
                        "continuing",
                        "90%",
                        "ContractWithEmployer",
                        "1",
                        "ZPROG001",
                        "403",
                        "1",
                        "25",
                        "16-18 Apprenticeship (From May 2017) Non-Levy Contract (non-procured)"});
#line 7
    testRunner.Given("the provider previously submitted the following learner details", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Delivery Period",
                        "On-Programme",
                        "Completion",
                        "Balancing"});
            table2.AddRow(new string[] {
                        "Aug/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Sep/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Oct/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Nov/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Dec/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Jan/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Feb/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Mar/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Apr/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "May/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Jun/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "Jul/Current Academic Year",
                        "750",
                        "0",
                        "0"});
#line 10
    testRunner.And("the following earnings had been generated for the learner", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "SFA Co-Funded Payments",
                        "Employer Co-Funded Payments"});
            table3.AddRow(new string[] {
                        "R01/Current Academic Year",
                        "Aug/Current Academic Year",
                        "675",
                        "75"});
            table3.AddRow(new string[] {
                        "R02/Current Academic Year",
                        "Sep/Current Academic Year",
                        "675",
                        "75"});
#line 25
    testRunner.And("the following provider payments had been generated", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "Priority",
                        "Start Date",
                        "Planned Duration",
                        "Total Training Price",
                        "Total Training Price Effective Date",
                        "Total Assessment Price",
                        "Total Assessment Price Effective Date",
                        "Actual Duration",
                        "Completion Status",
                        "SFA Contribution Percentage",
                        "Contract Type",
                        "Aim Sequence Number",
                        "Aim Reference",
                        "Framework Code",
                        "Pathway Code",
                        "Programme Type",
                        "Funding Line Type"});
            table4.AddRow(new string[] {
                        "learner a",
                        "1",
                        "start of academic year",
                        "12 months",
                        "9000",
                        "Aug/Current Academic Year",
                        "2250",
                        "Aug/Current Academic Year",
                        "12 months",
                        "continuing",
                        "90%",
                        "ContractWithEmployer",
                        "1",
                        "ZPROG001",
                        "403",
                        "1",
                        "25",
                        "16-18 Apprenticeship (From May 2017) Non-Levy Contract (non-procured)"});
#line 30
    testRunner.But("the Provider now changes the Learner details as follows", ((string)(null)), table4, "But ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Price details",
                        "Total Training Price",
                        "Total Training Price Effective Date",
                        "Total Assessment Price",
                        "Total Assessment Price Effective Date"});
            table5.AddRow(new string[] {
                        "1st price details",
                        "9000",
                        "Aug/Current Academic Year",
                        "2250",
                        "Aug/Current Academic Year"});
            table5.AddRow(new string[] {
                        "2nd price details",
                        "1200",
                        "Oct/Current Academic Year",
                        "200",
                        "Oct/Current Academic Year"});
#line 34
 testRunner.And("price details as follows", ((string)(null)), table5, "And ");
#line 39
    testRunner.When(string.Format("the amended ILR file is re-submitted for the learners in collection period {0}", collection_Period), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Delivery Period",
                        "On-Programme",
                        "Completion",
                        "Balancing"});
            table6.AddRow(new string[] {
                        "Aug/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Sep/Current Academic Year",
                        "750",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Oct/Current Academic Year",
                        "-100",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Nov/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Dec/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Jan/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Feb/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Mar/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Apr/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "May/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Jun/Current Academic Year",
                        "0",
                        "0",
                        "0"});
            table6.AddRow(new string[] {
                        "Jul/Current Academic Year",
                        "0",
                        "0",
                        "0"});
#line 41
    testRunner.Then("the following learner earnings should be generated", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "On-Programme",
                        "Completion",
                        "Balancing"});
            table7.AddRow(new string[] {
                        "R03/Current Academic Year",
                        "Oct/Current Academic Year",
                        "-100",
                        "0",
                        "0"});
#line 55
    testRunner.And("only the following payments will be calculated", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "SFA Co-Funded Payments",
                        "Employer Co-Funded Payments",
                        "Transaction Type"});
            table8.AddRow(new string[] {
                        "R03/Current Academic Year",
                        "Oct/Current Academic Year",
                        "-90",
                        "-10",
                        "Learning"});
#line 58
    testRunner.And("only the following provider payments will be recorded", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Collection Period",
                        "Delivery Period",
                        "SFA Co-Funded Payments",
                        "Employer Co-Funded Payments",
                        "Transaction Type"});
            table9.AddRow(new string[] {
                        "R03/Current Academic Year",
                        "Oct/Current Academic Year",
                        "-90",
                        "-10",
                        "Learning"});
#line 61
    testRunner.And("at month end only the following provider payments will be generated", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
