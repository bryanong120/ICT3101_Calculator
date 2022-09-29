Feature: UsingCalculatorMusa
	Simple calculator for adding two numbers

	@Musa
	Scenario: Calculating Basic Musa model's failures/intensities
		Given I have a calculator
		When I have entered 100, 50, 10, 10  into the calculator and press Musa
		Then the failure intenstiy result should be 5 and the expected failures should be 63