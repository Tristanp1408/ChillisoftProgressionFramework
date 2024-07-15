using FluentAssertions;
using Interfaces.Vehicle;
using NSubstitute;
using NUnit.Framework;

namespace Interfaces.Tests;

[TestFixture]
public class VehicleTests
{
    [Test]
    public void Car_VehicleDetails_ShouldPrintCorrectMessage()
    {
        // Arrange
        var car = new Car("Toyota", "Yaris");
        var expectedMessage = "Driving a car: Toyota Yaris";

        // Act
        using var sw = new StringWriter();
        Console.SetOut(sw);
        car.VehicleDetails();
        var consoleOutput = sw.ToString().Trim();

        // Assert
        consoleOutput.Should().Be(expectedMessage);
    }

    [Test]
    public void Truck_VehicleDetails_ShouldPrintCorrectMessage()
    {
        // Arrange
        var truck = new Truck("MAN", "TGS");
        var expectedMessage = "Driving a truck: MAN TGS";

        // Act
        using var sw = new StringWriter();
        Console.SetOut(sw); 
        truck.VehicleDetails();
        var consoleOutput = sw.ToString().Trim(); 

        // Assert
        consoleOutput.Should().Be(expectedMessage);
    } 
}