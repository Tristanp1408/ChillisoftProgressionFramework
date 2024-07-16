using FluentAssertions;
using NUnit.Framework;

namespace Generics.Tests;

[TestFixture]
public class LinkedListContainerTests
{
    [Test]
    public void Add_ShouldReturnSuccess()
    {
        // Arrange
        var linkedListContainer = CreateLinkedListContainer();
        linkedListContainer.Add(10);
        linkedListContainer.Add(20);

        // Act & Assert
        linkedListContainer.Count.Should().Be(2);
    }

    [Test]
    public void Remove_ShouldReturnSuccess()
    {
        // Arrange
        var linkedListContainer = CreateLinkedListContainer();
        linkedListContainer.Add(10);
        linkedListContainer.Add(20);

        // Act
        var removedItem = linkedListContainer.Remove();

        // Assert
        linkedListContainer.Count.Should().Be(1);
        removedItem.Should().Be(10);
    }

    [Test]
    public void Peek_ShouldReturnSuccess()
    {
        // Arrange
        var linkedListContainer = CreateLinkedListContainer();
        linkedListContainer.Add(10);
        linkedListContainer.Add(20);

        // Act
        var peekedItem = linkedListContainer.Peek();

        // Assert
        linkedListContainer.Count.Should().Be(2);
        peekedItem.Should().Be(10);
    }

    [Test]
    public void RemoveFromEmptyLinkedList_ShouldReturnDefault()
    {
        // Act
        var linkedListContainer = CreateLinkedListContainer();
        var removedItem = linkedListContainer.Remove();

        // Assert
        removedItem.Should().Be(default);
    }

    [Test]
    public void PeekFromEmptyLinkedList_ShouldReturnDefault()
    {
        // Act
        var linkedListContainer = CreateLinkedListContainer();
        var peekedItem = linkedListContainer.Peek();

        // Assert
        peekedItem.Should().Be(default);
    }

    [Test]
    public void GetLastItemFromList_ShouldReturnLastItemLinkedList()
    {
        // Arrange
        var linkedListContainer = CreateLinkedListContainer();
        linkedListContainer.Add(10);
        linkedListContainer.Add(20);

        // Act
        var lastItem = linkedListContainer.GetLastItemFromList();

        // Assert
        lastItem.Should().Be(20);
    }

    public LinkedListContainer<int> CreateLinkedListContainer()
    {
        return new LinkedListContainer<int>();
    }   
}