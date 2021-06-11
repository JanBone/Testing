Feature: Standard Mode Calculations
Test of correctness of selected functions: memory and history.

Scenario Outline: Performing  operations on two numbers, result verification. Result retrieving from history and validation.
	Given I navigated to Standard Calculator
	And I entered <First Number> into calculator
	And I press <Operand>
	And I entered <Second Number> into calculator
	When I press equal
	Then the result should be <Result> on the screen
	Given I press clear
	And I choose History label
	When I click the last element in History 
	Then the result should be <Result> on the screen
	And the calculator expression is <Expression>

Scenarios: 
		| First Number | Second Number | Result | Expression | Operand		|
		| 50           | 70            | 120    | 50 + 70    |plus			|
		| 10           | 13            | 130    | 10 × 13    |multiply      |

Scenario Outline: Performing  operations on two numbers and retrieving from memory, result verification.
	Given I navigated to Standard Calculator
	And I entered <First Number> into calculator
	And I add to a memory 
	And I entered <Second Number> into calculator
	And I add to a memory 
	Given I press clear
	And I choose Memory label
	When I click the last element in Memory 
	Then the result should be <Result> on the screen


Scenarios: 
		| First Number | Second Number | Result | 
		| 50           | 70            | 120    |
		| 10           | 13            | 23    | 
