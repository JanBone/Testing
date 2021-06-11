Feature: Programmer Calculator Convertion	 
Performing conversion operation and and validation of the result on different numbers

Scenario Outline: Convert  number to hexadecimal, decimal, octal, binary 
	Given I navigated to Programmer Calculator
	And I entered <Number> into calculator
	Then the hexadecimal result should be <Hexadecimal result> on the screen
	And the decimal result should be <Decimal result> on the screen
	And the octal result should be <Octal result> on the screen
	And the binary result should be <Binary result> on the screen
Scenarios: 
		| Number | Hexadecimal result | Decimal result | Octal result | Binary result |
		| 50     | 32                 | 50             |62            | 00110010      |
		| 14     | E                  | 14             |16	          | 1110          |
		| 175    | AF                 | 175            |257           | 10101111      |
