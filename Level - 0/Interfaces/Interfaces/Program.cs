using Interfaces.Interfaces;
using Interfaces.Notification;
using Interfaces.Vehicle;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowingUseOfPolymorphism();

            DemonstrationNotificationSystem();
        }

        private static void DemonstrationNotificationSystem()
        {
            var user1 = new User("Alice", [
                new EmailNotifier(),
                new SmsNotifier()
            ]);

            var user2 = new User("Bob", [
                new WhatsAppNotifier(),
                new SmsNotifier()
            ]);

            var message = "You have a new message!";

            // Notify all users using all their notifiers
            Console.WriteLine("Regular Notification:");
            user1.Notify(message);
            user2.Notify(message);

            // Notify all users using the highest priority notifier
            Console.WriteLine("\nNotification with Priority:");
            user1.NotifyWithPriority(message);
            user2.NotifyWithPriority(message);
        }

        public static void ShowingUseOfPolymorphism()
        {
            var car = new Car("Toyota", "Yaris");
            var truck = new Truck("MAN", "TGS");

            // Use polymorphism to call the Drive method on both instances
            car.VehicleDetails();
            truck.VehicleDetails();

            Console.WriteLine("\n");

            // Demonstrate polymorphism by storing different vehicle types in an array
            var vehicles = new List<IVehicle>
            {
                new Car("Honda", "Civic"),
                new Truck("Chevy", "Silverado"),
                new Car("Mazda", "3")
            };

            // Iterate through the array and call the Drive method on each vehicle
            vehicles.ForEach(x => x.VehicleDetails());
            Console.WriteLine("\n");
        }
    }
}