using Generics.Interfaces;
using Generics.Objects;

namespace Generics.Repository;

public class ProductRepository: IRepository<Product>
{
    private readonly List<Product> _products = [];

    // Adds a product to the repository.
    public void Add(Product item)
    {
        _products.Add(item);
        Console.WriteLine($"Product {item.Name} added.");
    }

    // Removes a product from the repository.
    public void Remove(Product item)
    {
        _products.Remove(item);
        Console.WriteLine($"Product {item.Name} removed.");
    }

    // Retrieves a product from the repository by its ID.
    public Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id)!;
    }
}