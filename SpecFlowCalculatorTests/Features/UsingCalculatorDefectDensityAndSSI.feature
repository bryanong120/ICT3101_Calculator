Feature: UsingCalculatorDefectDensityAndSSI
	Simple calculator for adding two numbers

@DefectDensity
Scenario: Current Defect Density
	Given I have a calculator
	When I have entered 100 and 2 into the calculator and press Defect Density
	Then the defect density result should be 50
	
@DefectDensity
Scenario: Current SSI
	Given I have a calculator
	When I have entered 10, 20, 0 and 20 into the calculator and press SSI
	Then the SSI result should be 10