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
    [Scope(Feature = "Programmer Calculator Convertion")]
    public class ProgrammerCalculatorConvertionSteps : BaseSteps
    {
        private readonly Calculator _calculator;


        public ProgrammerCalculatorConvertionSteps(Calculator calculator) :  base(calculator)
        {
            _calculator = calculator;
        }

        
        
      
        
        [Then(@"the (.*) result should be (.*) on the screen")]
        public void ThenTheDecimalResultShouldBeOnTheScreen(string p0, string p1)
        {
            _calculator.GetProgrammerResults(p0).Should().Be(p1);
        }
        
     
    }
}
