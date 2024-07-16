using FluentAssertions;
using Generics.Objects;
using Generics.Repository;
using NUnit.Framework;

namespace Generics.Tests;

[TestFixture]
public class ProductRepositoryTests
{
    [Test]
    public void Add_ShouldReturnSuccess()
    {
        // Arrange
        var product = new Product { Id = 1, Name = "Laptop", Description = "Brand new" };
        var productRepository = CreateProductRepository();

        // Act
        productRepository.Add(product);

        // Assert
        var retrievedProduct = productRepository.GetById(1);

        retrievedProduct.Should().NotBeNull();
        retrievedProduct.Id.Should().Be(1);
        retrievedProduct.Name.Should().Be("Laptop");
        retrievedProduct.Description.Should().Be("Brand new");
    }

    [Test]
    public void Remove_ShouldReturnSuccess()
    {
        // Arrange
        var product = new Product { Id = 1, Name = "Laptop", Description = "Brand new" };
        var productRepository = CreateProductRepository();

        productRepository.Add(product);

        // Act
        productRepository.Remove(product);

        // Assert
        var retrievedProduct = productRepository.GetById(1);
        retrievedProduct.Should().BeNull();
    }

    [Test]
    public void GetById_ShouldReturnNotFound()
    {
        // Act
        var productRepository = CreateProductRepository();
        var retrievedProduct = productRepository.GetById(1);

        // Assert
        retrievedProduct.Should().BeNull();
    }

    public ProductRepository CreateProductRepository()
    {
        return new ProductRepository();
    }
}