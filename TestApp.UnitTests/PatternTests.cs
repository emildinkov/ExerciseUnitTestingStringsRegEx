using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("abcdef", 2, "aBcDeFaBcDeF")]
    [TestCase("abcdef", 5, "aBcDeFaBcDeFaBcDeFaBcDeFaBcDeF")]
    [TestCase("abcdef", 1, "aBcDeF")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 1;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {

        // Arrange
        string input = "abcd";
        int repetitionFactor = -5;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }


    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcd";
        int repetitionFactor = 0;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
}
