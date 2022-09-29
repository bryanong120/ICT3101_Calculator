using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests;

[TestFixture]
public class AdditionalCalculatorTests
{
    private Calculator _calculator;
    private Mock<IFileReader> _mockFileReader;

    [SetUp]
    public void Setup()
    {
        _mockFileReader = new Mock<IFileReader>();
        _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt")).Returns(new string[6] {"123", "123", "321", "23", "112", "232"});
        _calculator = new Calculator();
    }
    
    [Test]
    public void GenMagicNum_GetNumber464Mock()
    {
        // Act
        double result = _calculator.GenMagicNum(5, _mockFileReader.Object); 
        // Assert
        Assert.That(result, Is.EqualTo(464));
    }
}