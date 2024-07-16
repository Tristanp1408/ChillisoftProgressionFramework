using FluentAssertions;
using NUnit.Framework;

namespace Generics.Tests;

[TestFixture]
public class StackContainerTests
{
    [Test]
    public void Add_ShouldReturnSuccess()
    {
        // Arrange
        var stackContainer = CreateStackContainer();

        stackContainer.Add(1);
        stackContainer.Add(2);

        // Act & Assert
        stackContainer.Count.Should().Be(2);
    }

    [Test]
    public void Remove_ShouldReturnSuccess()
    {
        // Arrange
        var stackContainer = CreateStackContainer();

        stackContainer.Add(1);
        stackContainer.Add(2);

        // Act
        var removedItem = stackContainer.Remove();

        // Assert
        stackContainer.Count.Should().Be(1);
        removedItem.Should().Be(2);
    }

    [Test]
    public void Peek_ShouldReturnSuccess()
    {
        // Arrange
        var stackContainer = CreateStackContainer();
        stackContainer.Add(1);
        stackContainer.Add(2);

        // Act
        var peekedItem = stackContainer.Peek();

        // Assert
        stackContainer.Count.Should().Be(2);
        peekedItem.Should().Be(2);
    }

    [Test]
    public void RemoveFromEmptyStack_ShouldReturnDefault()
    {
        // Act
        var stackContainer = CreateStackContainer();
        var removedItem = stackContainer.Remove();

        // Assert
        removedItem.Should().Be(default);
    }

    [Test]
    public void PeekFromEmptyStack_ShouldReturnDefault()
    {
        // Act
        var stackContainer = CreateStackContainer();
        var peekedItem = stackContainer.Peek();

        // Assert
        peekedItem.Should().Be(default);
    }

    public StackContainer<int> CreateStackContainer()
    {
        return new StackContainer<int>();
    }
}