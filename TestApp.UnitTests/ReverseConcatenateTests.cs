using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string excpected = "";

        // Act
        string output = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(output, Is.EqualTo(excpected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new string[] { "Hello" };
        string expected = "Hello";

        // Act
        string output = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That (output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "hello", "emil" };
        string expected = "emilhello";

        // Act
        string output = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[]? input = null;

        // Act
        string output = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        //Assert
        Assert.That(output, Is.EqualTo(""));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { " ", "  " };
        string expected = "   ";

        // Act
        string output = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "hello", "emil", "123", "car", "owner" };
        string expected = "ownercar123emilhello";

        // Act
        string output = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
