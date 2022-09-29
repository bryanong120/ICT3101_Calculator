Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failure/intensities
	As a Software Quality Metric Enthusiast
	I want to use my calculator

@BasicReliability
Scenario: Current failure intensity
	Given I have a calculator
	When I have entered 100, 50 and 10 into the calculator and press current failure
	Then the current failure intensity result should be 5
	
@BasicReliability
Scenario: Current expected failure intensity
	Given I have a calculator
	When I have entered 100, 10 and 10 into the calculator and press average number of expected failure
	Then the average number of expected failure result should be 63
