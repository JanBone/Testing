Feature: Scientific Mode Calculations
Test of selected functions in scientific mode of calculator
and validation of the results.


Scenario Outline: Add Two Numbers in Scientific Mode
	Given I navigated to Scientific Calculator
	And I entered <SummandOne> into calculator
	And I press plus
	And I entered <SummandTwo> into calculator
	When I press equal
	Then the result should be <Result> on the screen

Scenarios: 
		| SummandOne | SummandTwo | Result |       
		| 50         | 70         | 120    | 
		| 1          | 10         | 11     |

Scenario Outline: Subtract Two Numbers in Scientific Mode
	Given I navigated to Scientific Calculator
	And I entered <Minuend> into calculator
	And I press minus
	And I entered <Subtrahend> into calculator
	When I press equal
	Then the result should be <Result> on the screen

Scenarios: 
		| Minuend    | Subtrahend | Result |       
		| 24         | 10         | 14     | 
		| 10         | 5          | 5      |


Scenario Outline: Factorial of the number in Scientific Mode
	Given I navigated to Scientific Calculator
	And I entered <Number> into calculator
	And I press factorial
	When I press equal
	Then the result should be <Result> on the screen

Scenarios: 
		| Number  | Result    |       
		| 5       | 120       | 
		| 10      | 3 628 800 |

