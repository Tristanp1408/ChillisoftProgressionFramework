using Interfaces.Interfaces;

namespace Interfaces.Notification;

public class EmailNotifier: INotifier
{
    public int Priority => 1;
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending Email notification: {message}");
    }
}