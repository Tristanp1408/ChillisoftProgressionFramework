namespace Interfaces.Vehicle;

// Truck class inherits from Vehicle and can override the Drive method
public class Truck: Vehicle
{
    public Truck(string make, string model) : base(make, model)
    {
    }

    // Override the Drive method to provide specific behavior for trucks
    public override void VehicleDetails()
    {
        Console.WriteLine($"Driving a truck: {Make} {Model}");
    }
}