using Interfaces.Interfaces;

namespace Interfaces.Vehicle;

// Create a class that implements shared functionality
public abstract class Vehicle : IVehicle
{
    protected Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public string Make { get; set; }
    public string Model { get; set; }

    // Create functionality for the method declared in the Interface
    public virtual void VehicleDetails()
    {
        Console.WriteLine($"Driving a {Make} {Model}");
    }
}