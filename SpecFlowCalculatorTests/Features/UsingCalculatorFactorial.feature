Feature: UsingCalculatorFactorial
	Simple calculator for adding two numbers

@Factorials
Scenario: Factorial one number
	Given I have a calculator
	When I have entered 5 into the calculator and press factorial
	Then the factorial result should be 120
	
	
@Factorials
Scenario: Factorial zero
	Given I have a calculator
	When I have entered 0 into the calculator and press factorial
	Then the factorial result should be 1