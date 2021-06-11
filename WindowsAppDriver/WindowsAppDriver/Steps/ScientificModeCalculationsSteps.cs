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
    [Scope(Feature = "Scientific Mode Calculations")]
    public class ScientificModeCalculationsSteps : BaseSteps
    {
        private readonly Calculator _calculator;

        public ScientificModeCalculationsSteps(Calculator calculator) : base(calculator)
        {
            _calculator = calculator;
        }
        
    }
}
