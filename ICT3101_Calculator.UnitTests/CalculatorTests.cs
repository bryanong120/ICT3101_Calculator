using System.Runtime.CompilerServices;

namespace ICT3101_Calculator.UnitTests;

public class CalculatorTests
{
    private Calculator _calculator;
    
    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }

    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20); 
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }

    // [Test]
    // [TestCase(0, 0)]
    // [TestCase(0, 10)]
    // [TestCase(10, 0)]
    // public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
    // {
    //     //Assert
    //     Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    // }

    //Factorial Tests
    [Test]
    public void Factorial_WithDecimalAsInput_ResultThrowArgumentException()
    {
        Assert.That(() => _calculator.Factorial(3.2), Throws.ArgumentException);
    }
    
    [Test]
    public void Factorial_WithZeroAsInput_ResultEqualToOne()
    {
        Assert.That(() => _calculator.Factorial(0), Is.EqualTo(1));
    }
    
    [Test]
    public void Factorial_WithNegativeAsInput_ResultThrowArgumentException()
    {
        Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
    }
    
    //Triangle Tests
    [Test]
    public void Triangle_CalculateAreaWithInt_ResultEqualToSum()
    {
        Assert.That(() => _calculator.Triangle(10, 5), Is.EqualTo(25));
    }
    
    [Test]
    public void Triangle_CalculateAreaWithDecimal_ResultEqualToSum()
    {
        Assert.That(() => _calculator.Triangle(10.2, 5.3), Is.EqualTo(27.03));
    }
    //One for negative value
    //Another for values = 0
    
    //Circle Tests
    [Test]
    public void Circle_CalculateAreaWithInt_ResultEqualToSum()
    {
        Assert.That(() => _calculator.Circle(10), Is.EqualTo(314.16));
    }
    //add more test cases
    
    //question 17 unknown test cases for A
    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result() {
        // Act
        double result = _calculator.UnknownFunctionA(5, 5); 
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    
    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result() {
        // Act
        double result = _calculator.UnknownFunctionA(5, 4); 
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    
    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result() {
        // Act
        double result = _calculator.UnknownFunctionA(5, 3); 
        // Assert
        Assert.That(result, Is.EqualTo(60));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest3_Result()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
    }
    
    
    [Test]
    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException() {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
    }
    
    //question 17 unknown test cases for B
    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result() {
        // Act
        double result = _calculator.UnknownFunctionB(5, 5); 
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result() {
        // Act
        double result = _calculator.UnknownFunctionB(5, 4); 
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    
    
    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result() {
        // Act
        double result = _calculator.UnknownFunctionB(5, 3); 
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    
    [Test]
    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException() {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(-4,5), Throws.ArgumentException);
    }
    
    [Test]
    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException() {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(4,5), Throws.ArgumentException);
    }

    [Test]
    public void GenMagicNum_GetNumber464()
    {
        // Act
        double result = _calculator.GenMagicNum(5, new FileReader()); 
        // Assert
        Assert.That(result, Is.EqualTo(464));
    }
}