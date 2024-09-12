using Delegates;
using FluentAssertions;
using NUnit.Framework;
using static Delegates.Calculator;



namespace Tests.Delegates
{
    [TestFixture]
    public class TestDelegates
    {
        [Test]
        public void Add_ShouldReturnSum_WhenTwoNumbersArePassed()
        {
            // Arrange
            var calculator = CreateCalculator();
            var add = new MathOperation(calculator.Add);

            // Act
            var result = calculator.ExecuteOperation(add, 5, 3);

            // Assert
            result.Should().Be(8);
        }

        [Test]
        public void Subtract_ShouldReturnDifference_WhenTwoNumbersArePassed()
        {
            // Arrange
            var calculator = CreateCalculator();
            var subtract = new MathOperation(calculator.Subtract);

            // Act
            var result = calculator.ExecuteOperation(subtract, 5, 3);

            // Assert
            result.Should().Be(2);
        }

        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
