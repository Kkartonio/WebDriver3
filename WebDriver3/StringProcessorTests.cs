using FluentAssertions;
using NUnit.Framework;

[TestFixture]
public class StringProcessorTests
{
    private StringProcessor _processor;

    [SetUp]
    public void Setup()
    {
        _processor = new StringProcessor();
    }

    [Test]
    public void CountMaxUnequalConsecutiveChars_ShouldReturnCorrectValue()
    {
        // Arrange
        var input = "aabbccdd";

        // Act
        var result = _processor.CountMaxUnequalConsecutiveChars(input);

        // Assert
        result.Should().Be(2);
    }

    [Test]
    public void CountMaxConsecutiveIdenticalLetters_ShouldReturnCorrectValue()
    {
        // Arrange
        var input = "aaabbbbccccc";

        // Act
        var result = _processor.CountMaxConsecutiveIdenticalLetters(input);

        // Assert
        result.Should().Be(5);
    }

    [Test]
    public void CountMaxConsecutiveIdenticalDigits_ShouldReturnCorrectValue()
    {
        // Arrange
        var input = "112233445566";

        // Act
        var result = _processor.CountMaxConsecutiveIdenticalDigits(input);

        // Assert
        result.Should().Be(2);
    }
}
