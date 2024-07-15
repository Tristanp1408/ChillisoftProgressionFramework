using Interfaces.Interfaces;

namespace Interfaces.Notification;

public class WhatsAppNotifier: INotifier
{
    public int Priority => 3;
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending WhatsApp notification: {message}");
    }
}