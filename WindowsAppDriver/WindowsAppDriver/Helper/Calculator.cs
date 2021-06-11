
using OpenQA.Selenium;
using System;
using WindowsAppDriver.Driver;

namespace WindowsAppDriver.Helper
{
    public class Calculator
    {
        private readonly WinAppDriver _driver;

        public Calculator(WinAppDriver driver)
        {
            _driver = driver;

        }

        public void EnterNumber(string number)
        {
            foreach (char c in number)
            {
                _driver.Current.FindElementByAccessibilityId("num" + c + "Button").Click();
            }
        }

        public void EnterSign(string sign)
        {
            _driver.Current.FindElementByAccessibilityId(sign + "Button").Click();
        }

        public void NavigateToMode(string modeId)
        {
            try
            {
                // Current version of Calculator application
                _driver.Current.FindElementByAccessibilityId("TogglePaneButton").Click();
            }
            catch
            {
                // Previous version of Calculator application
                _driver.Current.FindElementByAccessibilityId("NavButton").Click();
            }

            try
            {
                _driver.Current.FindElementByClassName("SplitViewPane").FindElementByAccessibilityId(modeId).Click();
            }
            catch
            {
                throw (new System.ArgumentException("The mode is not valid"));
            }

        }

        public void SelectDateCalculatorMode(string mode)
        {
            int index;
            _driver.Current.FindElementByAccessibilityId("DateCalculationOption").Click();
            switch (mode)
            {
                case "Date Difference":
                    index = 0;
                    break;
                case "Day Difference":
                    index = 1;
                    break;

                default:
                    throw (new System.ArgumentException("The mode is not valid"));
            }
            _driver.Current.FindElementsByClassName("ComboBoxItem")[index].Click();
        }

        public void SelectDateFrom()
        {
            _driver.Current.FindElementByAccessibilityId("NavButton").Click();
        }
        public void PressCalendarButton(string button)
        {
            string id;
            switch (button)
            {
                case "From":
                    id = "DateDiff_FromDate";
                    break;
                case "To":
                    id = "DateDiff_ToDate";
                   
                    break;
                case "From date":
                    id = "AddSubtract_FromDate";
                    break;
                default:
                    throw (new System.ArgumentException("No such a button"));
            }
            _driver.Current.FindElementByAccessibilityId(id).Click();
        }

        public void ChooseYear(string year)
        {
            _driver.Current.FindElementByName(year).Click();
        }
        public void ChooseMonth(string month)
        {

            _driver.Current.FindElementByName(month).Click();
        }
        public void SelectCalendarOption(string option)
        {

            _driver.Current.FindElementByAccessibilityId(option + "Option").Click();
        }

        public void ChooseValue(string number, string section)
        {
            _driver.Current.FindElementByAccessibilityId(section + "Value").Click();
            _driver.Current.FindElementByName(number).Click();
        }



        public void ChooseDay(string day)
        {

            _driver.Current.FindElementByName(day).Click();
        }
        public void PressHeaderButton()  //Header button of the calendar
        {
            _driver.Current.FindElementByAccessibilityId("HeaderButton").Click();
        }

        public string DateDifferenceResult()  
        {
            return _driver.Current.FindElementByAccessibilityId("DateDiffAllUnitsResultLabel").Text.Replace("Różnica ", "").Trim();
        }
        public string DayDifferenceResult()
        {
            return _driver.Current.FindElementByAccessibilityId("DateResultLabel").Text.Replace("Wynikowa data ‎", "").Trim();
        }

        public string GetTitle()
        {
            return _driver.Current.FindElementByAccessibilityId("Header").Text.Trim();  
        }


        public string GetResult()  //Result of Standard and Programmer calculators
        {
            return _driver.Current.FindElementByAccessibilityId("CalculatorResults").Text.Trim().Replace("Wyświetlana wartość to", "").Replace(" ", "");
        }
     
        public string GetProgrammerResults(string mode)   
        {
            string toReplace_, btnName;
            switch (mode)
            {
                case "hexadecimal":
                    btnName = "hex";
                    toReplace_ = "Wartość szesnastkowa";
                    break;
                case "decimal":
                    btnName = "decimal";
                    toReplace_ = "Wartość dziesiętna";
                    break;
                case "octal":
                    btnName = "octol";
                    toReplace_ = "Wartość ósemkowa";
                    break;
                case "binary":
                    btnName = "binary";
                    toReplace_ = "Wartość binarna";
                    break;
                default:
                    throw (new System.ArgumentException("The mode is not valid"));
            }
            return _driver.Current.FindElementByAccessibilityId(btnName+"Button").Text.Replace(toReplace_, "").Replace(" ", "");

        }
        public void AdditionalCalculatorElementsAccess(string button)  //History and memory buttons 
        {
            _driver.Current.FindElementByAccessibilityId(button + "Label").Click();
        }


        public void LastElementFromHistoryMemory(string p0)  //Last element of a history pane
        {
            _driver.Current.FindElementByAccessibilityId(p0+"ListView").FindElementsByClassName("ListViewItem")[0].Click();
        }

        public string ExpressionRetrieved() 
        {
            return _driver.Current.FindElementByAccessibilityId("CalculatorExpression").Text.Replace("Wyrażenie ", "").Replace("=", "");
        }
        public void MemoryOperations(string operation)  //Memory buttons
        {
            string pom;
            switch (operation)
            {
                case "add":
                    pom = "MemPlus";
                    break;
                case "substract":
                    pom = "MemMinus";
                    break;
                default:
                    throw (new System.ArgumentException("The operation is not valid"));
            }
            _driver.Current.FindElementByAccessibilityId(pom).Click();

        }
    }
}
