using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorAvailabilityStepDefinition
{
    private double _result;
    private Calculator _calculator;

    public UsingCalculatorAvailabilityStepDefinition(Calculator calculator)
    {
        this._calculator = calculator;
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf(double p0, double p1)
    {
        _result = _calculator.Add(p0, p1);
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheAvailabilityResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
    {
        _result = _calculator.Availability(p0, p1);
    }
}