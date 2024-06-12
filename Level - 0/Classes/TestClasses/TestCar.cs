using Classes;
using FluentAssertions;
using NUnit.Framework;

namespace TestClasses;

[TestFixture]
public class TestCar
{
    [Test]
    public void Create_ShouldReturnCarDetailsObject()
    {
        // Arrange
        var make = "Toyota";
        var model = "Corolla";
        var year = 2020;

        // Act
        var car = CarDetails.Create(make, model, year);

        // Assert
        car.Should().NotBeNull();
        car.Make.Should().Be(make);
        car.Model.Should().Be(model);
        car.Year.Should().Be(year);
    }

    [Test]
    public void DisplayInfo_ShouldDisplayCorrectInfo()
    {
        // Arrange
        var car = CarDetails.Create("Toyota", "Corolla", 2020);
        var expectedOutput = $"Make: Toyota, Model: Corolla, Year: 2020{Environment.NewLine}";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        car.DisplayInfo();

        // Assert
        sw.ToString().Should().Be(expectedOutput);
    }
}