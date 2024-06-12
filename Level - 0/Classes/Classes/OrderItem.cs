namespace Classes;

public class OrderItem
{
    public string ItemName { get; set; }
    public decimal Price { get; set; }

    public OrderItem(string itemName, decimal price)
    {
        ItemName = itemName;
        Price = price;
    }
}