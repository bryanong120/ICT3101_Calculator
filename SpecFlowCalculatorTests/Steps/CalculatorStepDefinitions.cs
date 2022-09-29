using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private double _result;
    private Calculator _calculator;

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        this._calculator = new Calculator();
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press add")]
    public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
    {
        _result = _calculator.Add(p0, p1);
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}