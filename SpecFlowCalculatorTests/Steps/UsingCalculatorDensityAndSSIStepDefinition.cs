using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorDensityAndSSIStepDefinition
{
    private double _result;
    private Calculator _calculator;

    public UsingCalculatorDensityAndSSIStepDefinition(Calculator calculator)
    {
        this._calculator = calculator;
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press Defect Density")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(double p0, double p1)
    {
        _result = _calculator.Divide(p0, p1);
    }

    [Then(@"the defect density result should be (.*)")]
    public void ThenTheDefectDensityResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*), (.*), (.*) and (.*) into the calculator and press SSI")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSsi(double p0, double p1, double p2, double p3)
    {
        _result = _calculator.SSI(p0, p1, p2, p3);
    }

    [Then(@"the SSI result should be (.*)")]
    public void ThenTheSsiResultShouldBe(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}