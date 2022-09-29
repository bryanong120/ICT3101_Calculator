using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorDivisionStepDefinitions
{
    private double _result;
    private Calculator _calculator;

    public UsingCalculatorDivisionStepDefinitions(Calculator calculator)
    {
        this._calculator = calculator;
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
    public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
    {
        _result = _calculator.Divide(p0, p1);
    }

    [Then(@"the division result should be (.*)")]
    public void ThenTheResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [Then(@"the division result equals positive_infinity")]
    public void ThenTheResultEqualsPositive_Infinity()
    {
        Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
    }
}