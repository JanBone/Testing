Feature: Date Mode in Calculator
Testing of selected functions in a date mode of the Calculator.
"Add, Substract days from a date","Difference between dates"  functions are verified.

Scenario Outline: Difference between two dates
	Given I navigated to Date Calculator
	And I have selected Date Difference option in the calculator
	And I have pressed From button 
	And I have pressed Header button on the calendar
	And I have pressed Header button on the calendar
	And I have chosen year <Year> on the calendar
	And I have chosen month <Month> on the calendar
	And I have chosen day <Day> on the calendar
	And I have pressed To button 
	And I have pressed Header button on the calendar
	And I have pressed Header button on the calendar
	And I have chosen year <Year_2> on the calendar
	And I have chosen month <Month_2> on the calendar
	And I have chosen day <Day_2> on the calendar
	Then The date result <Difference> should be on the screen
	
Scenarios: 
	| Day | Month | Year | Day_2 | Month_2 | Year_2 | Difference	  |
	| 15  | maja  | 2021 | 10    | czerwca | 2021   |3 tygodnie; 5 dni|

	
Scenario Outline: Add days to a date 
	Given I navigated to Date Calculator
	And I have selected Day Difference option in the calculator
	And I have pressed From date button 
	And I have pressed Header button on the calendar
	And I have pressed Header button on the calendar
	And I have chosen year <Year> on the calendar
	And I have chosen month <Month> on the calendar
	And I have chosen day <Day> on the calendar
	And I have selected Add option 
	And I have entered <Years> into Years section
	And I have entered <Months> into Months section
	And I have entered <Days> into Days section
	Then The day result <Result> should be on the screen

Scenarios: 
	| Day | Month | Year | Years | Months | Days | Result							 |
	| 15  | maja  | 2022 | 15    | 10     | 10   | ‎poniedziałek‎, ‎15‎ ‎marca‎ ‎2038       |

Scenario Outline: Substract days from a date 
	Given I navigated to Date Calculator
	And I have selected Day Difference option in the calculator
	And I have pressed From date button 
	And I have pressed Header button on the calendar
	And I have pressed Header button on the calendar
	And I have chosen year <Year> on the calendar
	And I have chosen month <Month> on the calendar
	And I have chosen day <Day> on the calendar
	And I have selected Add option 
	And I have entered <Years> into Years section
	And I have entered <Months> into Months section
	And I have entered <Days> into Days section
	Then The day result <Result> should be on the screen

Scenarios: 
	| Day | Month | Year | Years | Months | Days | Result							 |
	| 15  | maja  | 2022 | 15    | 10     | 10   | ‎poniedziałek‎, ‎15‎ ‎marca‎ ‎2038       |