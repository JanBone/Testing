using System;
using System.Diagnostics;
using System.IO;
using WindowsAppDriver.Driver;
using WindowsAppDriver.Helper;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace WindowsAppDriver.Steps
{
    [Binding]
    [Scope(Feature = "Standard Mode Calculations")]
    public class StandardModeCalculationsSteps :BaseSteps
    {
        private readonly Calculator _calculator;

        public StandardModeCalculationsSteps(Calculator calculator) : base(calculator)
        {
            _calculator = calculator;
        }

        [Then(@"the calculator expression is (.*)")]
        public void ThenTheCalculatorExpressionFromTheIs(string p0)
        {
            _calculator.ExpressionRetrieved().Should().Be(p0); ;
        }



        [When(@"I click the last element in (.*)")]
        public void WhenIClickTheLastElementIn(string p0)
        {
            _calculator.LastElementFromHistoryMemory(p0);
        }

        [Given(@"I choose (.*) label")]
        public void GivenIChooseHistoryLabel(string p0)
        {
            _calculator.AdditionalCalculatorElementsAccess(p0);
        }

        [Given(@"I (.*) to a memory")]
        public void GivenIToAMemory(string p0)
        {
            _calculator.MemoryOperations(p0);
        }


    }
}
