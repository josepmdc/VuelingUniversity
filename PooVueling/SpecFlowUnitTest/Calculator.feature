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

Scenario: Subtract two numbers
	Given I have entered 5 into the calculator
	And I have also entered 2 into the calculator
	When I press subtract
	Then the result should be 3 on the screen

Scenario: Multiply two numbers
	Given I have entered 5 into the calculator
	And I have also entered 2 into the calculator
	When I press multiply
	Then the result should be 10 on the screen

Scenario: Divide two numbers
	Given I have entered 50 into the calculator
	And I have also entered 2 into the calculator
	When I press divide
	Then the result should be 25 on the screen
