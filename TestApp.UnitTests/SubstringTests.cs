using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class SubstringTests
{
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "The quick";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "brown fox jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the lazy";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "The quick brown fox jumps over the lazy dog";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
