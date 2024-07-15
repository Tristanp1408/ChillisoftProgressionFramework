namespace Interfaces.Interfaces;

public interface INotifier
{
    int Priority { get; }
    void SendNotification(string message);
}