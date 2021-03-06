﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.0.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable

namespace Pickles.Example.Features._02TagsAndHooks
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Addition")]
    public partial class AdditionFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "Hooks.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Addition",
                                                                "In order to explain the order in which hooks are run\r\nAs a SpecFlow evanglist\r\nI " +
                                                                "wan to  be able to hook into pre and post conditions in SpecFlow",
                                                                ProgrammingLanguage.CSharp, ((string[]) (null)));
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
        [NUnit.Framework.DescriptionAttribute("Hooking into pre conditions for Test Runs in SpecFlow")]
        public virtual void HookingIntoPreConditionsForTestRunsInSpecFlow()
        {
            var scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("Hooking into pre conditions for Test Runs in SpecFlow",
                                                   ((string[]) (null)));
#line 6
            this.ScenarioSetup(scenarioInfo);
#line 7
            testRunner.Given("the scenario is running");
#line 8
            testRunner.Then("the BeforeTestRun hook should have been executed");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Hooking into pre conditions for Features in SpecFlow")]
        public virtual void HookingIntoPreConditionsForFeaturesInSpecFlow()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "Hooking into pre conditions for Features in SpecFlow", ((string[]) (null)));
#line 10
            this.ScenarioSetup(scenarioInfo);
#line 11
            testRunner.Given("the scenario is running");
#line 12
            testRunner.Then("the BeforeFeature hook should have been executed");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Hooking into pre conditions for Scenarios in SpecFlow")]
        public virtual void HookingIntoPreConditionsForScenariosInSpecFlow()
        {
            var scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("Hooking into pre conditions for Scenarios in SpecFlow",
                                                   ((string[]) (null)));
#line 14
            this.ScenarioSetup(scenarioInfo);
#line 15
            testRunner.Given("the scenario is running");
#line 16
            testRunner.Then("the BeforeScenario hook should have been executed");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Hooking into pre conditions for ScenarioBlocks in SpecFlow")]
        public virtual void HookingIntoPreConditionsForScenarioBlocksInSpecFlow()
        {
            var scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("Hooking into pre conditions for ScenarioBlocks in SpecFlow",
                                                   ((string[]) (null)));
#line 18
            this.ScenarioSetup(scenarioInfo);
#line 19
            testRunner.Given("the scenario is running");
#line 20
            testRunner.Then("the BeforeScenarioBlock hook should have been executed");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Hooking into pre conditions for Steps in SpecFlow")]
        public virtual void HookingIntoPreConditionsForStepsInSpecFlow()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Hooking into pre conditions for Steps in SpecFlow",
                                                                  ((string[]) (null)));
#line 22
            this.ScenarioSetup(scenarioInfo);
#line 23
            testRunner.Given("the scenario is running");
#line 24
            testRunner.Then("the BeforeStep hook should have been executed");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion