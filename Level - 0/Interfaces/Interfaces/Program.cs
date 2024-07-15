using Interfaces.Interfaces;
using Interfaces.Vehicle;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Toyota", "Yaris");
            var truck = new Truck("MAN", "TGS");

            // Use polymorphism to call the Drive method on both instances
            car.VehicleDetails();
            truck.VehicleDetails();

            // Demonstrate polymorphism by storing different vehicle types in an array
            var vehicles = new List<IVehicle>
            {
                new Car("Honda", "Civic"),
                new Truck("Chevy", "Silverado"),
                new Car("Mazda", "3")
            };

            // Iterate through the array and call the Drive method on each vehicle
            foreach (var vehicle in vehicles)
            {
                vehicle.VehicleDetails();
            }
        }
    }
}
