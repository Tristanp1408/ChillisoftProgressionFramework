using Classes;
using FluentAssertions;
using NUnit.Framework;

namespace TestClasses;

[TestFixture]
public class TestOrder
{
    [Test]
    public void AddItem_ShouldAddItemToOrder()
    {
        // Arrange
        var order = new Order("12345");

        // Act
        order.AddItem("Laptop", 1500M);

        // Assert
        var firstOrder = order._items[0];
        order._items.Should().HaveCount(1);
        firstOrder.ItemName.Should().Be("Laptop");
        firstOrder.Price.Should().Be(1500);
    }

    [Test]
    public void CalculateTotalPrice_ShouldReturnSumOfAllItemPrices()
    {
        // Arrange
        var order = new Order("12345");

        order.AddItem("Laptop", 1500M)
            .AddItem("Mouse", 50M)
            .AddItem("Keyboard", 100M);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        order.DisplayInfo();

        // Assert

        // Calculate method is private and only used when logging out the total
        sw.ToString().Should().Contain("1650");
    }

    [Test]
    public void DisplayInfo_ShouldPrintOrderDetails()
    {
        // Arrange
        var order = new Order("12345");
        order.AddItem("Laptop", 1500M)
            .AddItem("Mouse", 50M);

        // Act
        using var sw = new StringWriter();
        Console.SetOut(sw);
        order.DisplayInfo();

        // Assert
        var result = sw.ToString();
        result.Should().Contain("Order ID: 12345")
            .And.Contain("Laptop: R1500")
            .And.Contain("Mouse: R50")
            .And.Contain("Total Price: R1550");
    }
}