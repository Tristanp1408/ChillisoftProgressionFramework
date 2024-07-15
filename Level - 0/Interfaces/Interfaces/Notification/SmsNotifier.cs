using Interfaces.Interfaces;

namespace Interfaces.Notification;

public class SmsNotifier: INotifier
{
    public int Priority => 2;
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS notification: {message}");
    }
}