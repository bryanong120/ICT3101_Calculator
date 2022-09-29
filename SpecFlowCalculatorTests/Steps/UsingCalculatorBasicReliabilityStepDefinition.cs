using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorBasicReliabilityStepDefinition
{
    private double _result;
    private Calculator _calculator;

    public UsingCalculatorBasicReliabilityStepDefinition(Calculator calculator)
    {
        this._calculator = calculator;
    }

    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press current failure")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCurrentFailure(double p0, double p1, double p2)
    {
        _result = _calculator.CurrentFailure(p0, p1, p2);
    }

    [Then(@"the current failure intensity result should be (.*)")]
    public void ThenTheCurrentFailureIntensityResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press average number of expected failure")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAverageNumberOfExpectedFailure(double p0, double p1, double p2)
    {
        _result = _calculator.ExpectedFailure(p0, p1, p2);
    }

    [Then(@"the average number of expected failure result should be (.*)")]
    public void ThenTheAverageNumberOfExpectedFailureResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}