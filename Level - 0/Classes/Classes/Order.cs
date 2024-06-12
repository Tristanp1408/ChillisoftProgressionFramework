namespace Classes;

// The Order class represents an order containing multiple items.
public class Order
{
    private readonly string _orderId;
    public readonly List<OrderItem> _items;

    // initializes fields
    public Order(string orderId)
    {
        _orderId = orderId;
        _items = new List<OrderItem>();
    }

    // Method to add an item to the order.
    // It takes the item name and price as parameters and returns the current Order object to allow method chaining.
    public Order AddItem(string itemName, decimal price)
    {
        _items.Add(new OrderItem(itemName, price));
        return this;
    }

    // It prints the order ID, list of items, and the total price to the console.
    public void DisplayInfo()
    {
        Console.WriteLine($"Order ID: {_orderId}");
        Console.WriteLine("Items:");

        foreach (var item in _items)
        {
            Console.WriteLine($"- {item.ItemName}: R{item.Price}");
        }

        Console.WriteLine($"Total Price: R{CalculateTotalPrice()}");
    }

    // It iterates through the list of items, sums their prices, and returns the total.
    private decimal CalculateTotalPrice()
    {
        var total = 0M;

        foreach (var item in _items)
        {
            total += item.Price;
        }

        return total;
    }
}