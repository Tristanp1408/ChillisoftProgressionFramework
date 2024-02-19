using FluentAssertions;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKataTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void GivenEmptyString_ShouldReturn0()
        {
            // Arrange
            var input = "";
            var expected = 0;
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void GivenOneNumber_ShouldReturnTheSameNumber()
        {
            // Arrange
            var input = "1";
            var expected = 1;
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void GivenTwoNumber_ShouldReturnTheSumOfBothNumbers()
        {
            // Arrange
            var input = "1, 2";
            var expected = 3;
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }

        [TestCase("1, 2, 3", 6)]
        [TestCase("1, 2, 3, 4", 10)]
        public void GivenMultipleNumbers_ShouldReturnTheSumOfNumbers(string input, int expected)
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void GivenNewLineAsADelimiterWithTwoNumbers_ShouldReturnSumOfNumbers()
        {
            // Arrange
            var input = "1\n2";
            var expected = 3;
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }


        [TestCase("1\n2", 3)]
        [TestCase("1\n2\n3\n4", 10)]
        [TestCase("1\n2\n3\n4\n5", 15)]
        public void GivenNewLineAsADelimiterWithMultipleNumbers_ShouldReturnSumOfNumbers(string input, int expected)
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }

        [Test]
        public void GivenCustomDelimiterWithTwoNumbers_ShouldReturnSumOfNumbers()
        {
            // Arrange
            var input = "//;\n1;2";
            var expected = 3;
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }

        [TestCase("//;\n1;2;3", 6)]
        [TestCase("//;\n1;2;3;4", 10)]
        public void GivenCustomDelimiterWithMultipleNumbers_ShouldReturnSumOfNumbers(string input, int expected)
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var result = sut.Add(input);

            // Assert
            result.Should().Be(expected);
        }
    }
}
