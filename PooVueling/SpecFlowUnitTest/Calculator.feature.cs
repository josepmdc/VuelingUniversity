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
namespace SpecFlowUnitTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Calculator", Description="\tI want to calculate some operations\r\n\tCalculate the sum of two numbers\r\n\tCalcula" +
        "te the subtraction of two numbers\r\n\tCalculate the multiplication of two numbers\r" +
        "\n\tCalculate the division of two numbers", SourceFile="Calculator.feature", SourceLine=0)]
    public partial class CalculatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Calculator.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Calculator", "\tI want to calculate some operations\r\n\tCalculate the sum of two numbers\r\n\tCalcula" +
                    "te the subtraction of two numbers\r\n\tCalculate the multiplication of two numbers\r" +
                    "\n\tCalculate the division of two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add two numbers", SourceLine=7)]
        public virtual void AddTwoNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("I have entered 50 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("I have also entered 70 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("the result should be 120 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void SubtractTwoNumbers(string input_1, string input_2, string button, string output, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtract two numbers", null, exampleTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
 testRunner.Given(string.Format("I have entered {0} into the calculator", input_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And(string.Format("I have also entered {0} into the calculator", input_2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I press subtract", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then(string.Format("the result should be {0} on the screen", output), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtract two numbers, 5", SourceLine=20)]
        public virtual void SubtractTwoNumbers_5()
        {
#line 14
this.SubtractTwoNumbers("5", "2", "subtract", "3", ((string[])(null)));
#line hidden
        }
        
        public virtual void MultiplyTwoNumbers(string input_1, string input_2, string button, string output, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiply two numbers", null, exampleTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
 testRunner.Given(string.Format("I have entered {0} into the calculator", input_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And(string.Format("I have also entered {0} into the calculator", input_2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When(string.Format("I press {0}", button), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then(string.Format("the result should be {0} on the screen", output), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiply two numbers, 10", SourceLine=29)]
        public virtual void MultiplyTwoNumbers_10()
        {
#line 23
this.MultiplyTwoNumbers("10", "2", "multiply", "20", ((string[])(null)));
#line hidden
        }
        
        public virtual void DivideTwoNumbers(string input_1, string input_2, string button, string output, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Divide two numbers", null, exampleTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
 testRunner.Given(string.Format("I have entered {0} into the calculator", input_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And(string.Format("I have also entered {0} into the calculator", input_2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.When(string.Format("I press {0}", button), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then(string.Format("the result should be {0} on the screen", output), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Divide two numbers, 50", SourceLine=38)]
        public virtual void DivideTwoNumbers_50()
        {
#line 32
this.DivideTwoNumbers("50", "2", "divide", "25", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
