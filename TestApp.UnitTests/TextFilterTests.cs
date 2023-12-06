using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new[] { "bear" }; 
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the lazy dog";

        // Act
        string output = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new[] { "fox" };
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown *** jumps over the lazy dog";

        // Act
        string output = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the lazy dog";

        // Act
        string output = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new[] { "brown fox" };
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick ********* jumps over the lazy dog";

        // Act
        string output = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
