namespace Interfaces.Vehicle;

// Car class inherits from Vehicle and can override the Drive method
public class Car : Vehicle
{
    public Car(string make, string model) : base(make, model)
    {
    }

    // This method is marked as virtual, meaning it can be overridden by derived classes
    public override void VehicleDetails()
    {
        Console.WriteLine($"Driving a car: {Make} {Model}");
    }
}