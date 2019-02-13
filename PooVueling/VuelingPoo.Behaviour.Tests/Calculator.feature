Feature: Calculator
	I want to calculate some operations
	Calculate the sum of two numbers
	Calculate the subtraction of two numbers
	Calculate the multiplication of two numbers
	Calculate the division of two numbers

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario Outline: Subtract two numbers
	Given I have entered <input_1> into the calculator
	And I have also entered <input_2> into the calculator
	When I press subtract
	Then the result should be <output> on the screen
		Examples: 
		| input_1 | input_2 | button   | output |
		| 5       | 2       | subtract | 3      |

Scenario Outline: Multiply two numbers
	Given I have entered <input_1> into the calculator
	And I have also entered <input_2> into the calculator
	When I press <button>
	Then the result should be <output> on the screen
		Examples: 
		| input_1 | input_2 | button   | output |
		| 10      | 2       | multiply | 20     |

Scenario Outline: Divide two numbers
	Given I have entered <input_1> into the calculator
	And I have also entered <input_2> into the calculator
	When I press <button>
	Then the result should be <output> on the screen
		Examples: 
		| input_1 | input_2 | button   | output |
		| 50      | 2       | divide   | 25     |