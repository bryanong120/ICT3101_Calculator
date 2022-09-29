using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorFactorialStepDefinition
{
    private double _result;
    private Calculator _calculator;
    
    public UsingCalculatorFactorialStepDefinition(Calculator calculator)
    {
        this._calculator = calculator;
    }

    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double p0)
    {
        _result = _calculator.Factorial(p0);
    }

    [Then(@"the factorial result should be (.*)")]
    public void ThenTheFactorialResultShouldBe(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}