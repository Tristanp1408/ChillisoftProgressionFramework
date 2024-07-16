using FluentAssertions;
using NUnit.Framework;

namespace Generics.Tests;

[TestFixture]
public class QueueContainerTests
{
    [Test]
    public void Add_ShouldReturnSuccess()
    {
        // Arrange
        var queueContainer = CreateQueueContainer();
        queueContainer.Add("First");
        queueContainer.Add("Second");

        // Act & Assert
        queueContainer.Count.Should().Be(2);
    }

    [Test]
    public void Remove_ShouldReturnSuccess()
    {
        // Arrange
        var queueContainer = CreateQueueContainer();
        queueContainer.Add("First");
        queueContainer.Add("Second");

        // Act
        var removedItem = queueContainer.Remove();

        // Assert
        queueContainer.Count.Should().Be(1);
        removedItem.Should().Be("First");
    }

    [Test]
    public void Peek_ShouldReturnSuccess()
    {
        // Arrange
        var queueContainer = CreateQueueContainer();
        queueContainer.Add("First");
        queueContainer.Add("Second");

        // Act
        var peekedItem = queueContainer.Peek();

        // Assert
        queueContainer.Count.Should().Be(2);
        peekedItem.Should().Be("First");
    }

    [Test]
    public void RemoveFromEmptyQueue_ShouldReturnDefault()
    {
        // Act
        var queueContainer = CreateQueueContainer();
        var removedItem = queueContainer.Remove();

        // Assert
        removedItem.Should().Be(default);
    }

    [Test]
    public void PeekFromEmptyQueue_ShouldReturnDefault()
    {
        // Act
        var queueContainer = CreateQueueContainer();
        var peekedItem = queueContainer.Peek();

        // Assert
        peekedItem.Should().Be(default);
    }

    public QueueContainer<string> CreateQueueContainer()
    {
        return new QueueContainer<string>();
    }
}