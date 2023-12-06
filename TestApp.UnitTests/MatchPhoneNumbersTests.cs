using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string output = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = "+359-22-1245-56787, +359.2.986 5432, +359-2!555!45555";

        // Act
        string output = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(output, Is.EqualTo(""));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = string.Empty;

        // Act
        string output = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(output, Is.EqualTo(""));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359.122.4986.445432, +359-2-555-5555";
        string expected = "+359-2-124-5678, +359-2-555-5555";

        // Act
        string output = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
