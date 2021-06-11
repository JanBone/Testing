using System;
using System.Diagnostics;
using System.IO;
using WindowsAppDriver.Driver;
using WindowsAppDriver.Helper;
using FluentAssertions;
using TechTalk.SpecFlow;


namespace WindowsAppDriver.Steps
{
    public class BaseSteps
    {
        private static Process _driver;
        private readonly Calculator _calculator;


        public BaseSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        [BeforeTestRun]
        public static void StartWinAppDriver()
        {
            try
            {
                var configurationDriver = new ConfigurationDriver();
                string winAppDriverPath = configurationDriver.Configuration["winAppPath"];
                _driver = Process.Start(winAppDriverPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not locate WinAppDriver.exe");
                throw new FileNotFoundException("Could not locate File WinAppDriver.exe", e);
            }
        }

        [AfterTestRun]
        public static void KillWinAppDriver()
        {
            _driver.Kill();
        }

        [Given(@"I navigated to (.*) Calculator")]
        public void GivenINavigatedTo(string p0)
        {
            _calculator.NavigateToMode(p0);
        }

        [Given(@"I entered (.*) into calculator")]
        public void GivenIEnteredIntoCalculator(string p0)
        {
            _calculator.EnterNumber(p0);
        }

        [Given(@"I press (.*)")]
        public void GivenIPress(string p0)
        {
            _calculator.EnterSign(p0);
        }

        [When(@"I press (.*)")]
        public void WhenIPressEquals(string p0)
        {
            _calculator.EnterSign(p0);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            _calculator.GetResult().Should().Be(p0);
        }

        [Then(@"Calculator title is (.*)")]
        public void ThenCalculatorTitleIs(string p0)
        {
            _calculator.GetTitle().Should().Be(p0);
        }

        
        

     


    }
}
