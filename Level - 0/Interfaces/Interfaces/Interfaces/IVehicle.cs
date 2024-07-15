namespace Interfaces.Interfaces;

// Define an interface that specifies common vehicle behavior
public interface IVehicle
{
    string Make { get; set; }
    string Model { get; set; }

    void VehicleDetails();
}