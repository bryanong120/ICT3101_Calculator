using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorMusaStepDefinition
{
    private double[]? _result;
    private Calculator _calculator;

    public UsingCalculatorMusaStepDefinition(Calculator calculator)
    {
        this._calculator = calculator;
    }

    [When(@"I have entered (.*), (.*), (.*), (.*)  into the calculator and press Musa")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressMusa(double p0, double p1, double p2, double p3)
    {
        _result = _calculator.Musa(p0, p1, p2, p3);
    }

    [Then(@"the failure intenstiy result should be (.*) and the expected failures should be (.*)")]
    public void ThenTheFailureIntenstiyResultShouldBeAndTheExpectedFailuresShouldBe(double p0, double p1)
    {
        if (_result != null)
        {
            Assert.That(_result[0], Is.EqualTo(p0));
            Assert.That(_result[1], Is.EqualTo(p1));
        }
    }
}