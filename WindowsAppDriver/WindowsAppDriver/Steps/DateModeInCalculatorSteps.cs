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
    [Scope(Feature = "Date Mode In Calculator")]
    public class DateModeInCalculatorSteps :BaseSteps
    {

        private readonly Calculator _calculator;


        public DateModeInCalculatorSteps(Calculator calculator) : base(calculator)
        {
            _calculator = calculator;
        }

       

        [Given(@"I have selected (.*) option in the calculator")]
        public void GivenIHaveSelectedOptionInTheCalculator(string p0)
        {
            _calculator.SelectDateCalculatorMode(p0);
        }

        [Given(@"I have pressed (.*) button")]
        public void GivenIHavePressedButton(string p0)
        {
            _calculator.PressCalendarButton(p0);
        }

        [Given(@"I have pressed Header button on the calendar")]
        public void GivenIHavePressedHeaderButtonOnTheCalendar()
        {
            _calculator.PressHeaderButton();
        }



        [Given(@"I have chosen year (.*) on the calendar")]
        public void GivenIHaveChosenYearOnTheCalendar(string p0)
        {
            _calculator.ChooseYear(p0);
        }


        [Given(@"I have chosen month (.*) on the calendar")]
        public void GivenIHaveChosenMonthOnTheCalendar(string p0)
        {
            _calculator.ChooseMonth(p0);
        }

        [Given(@"I have chosen day (.*) on the calendar")]
        public void GivenIHaveChosenDayOnTheCalendar(string p0)
        {
            _calculator.ChooseDay(p0);
        }

        
       
        [Then(@"The day result (.*) should be on the screen")]
        public void GivenTheDayResultShouldBeOnTheScreen(string p0)
        {
            _calculator.DayDifferenceResult().Should().Be(p0);
        }


        [Then(@"The date result (.*) should be on the screen")]
        public void ThenTheDateResultTygodnieDniShouldBeOnTheScreen(string p0)
        {
            _calculator.DateDifferenceResult().Should().Be(p0);
        }







        [Given(@"I have selected (.*) option")]
        public void GivenIHaveSelectedOption(string p0)
        {
            _calculator.SelectCalendarOption(p0);
        }
        [Given(@"I have entered (.*) into (.*) section")]
        public void GivenIHaveEnteredIntoSection(string p0, string p1)
        {
            _calculator.ChooseValue(p0, p1);
        }

      




    }

}
