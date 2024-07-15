using Interfaces.Interfaces;

namespace Interfaces.Notification;

public class User
{
    public string Name { get; set; }
    public List<INotifier> Notifiers { get; set; }

    public User(string name, List<INotifier> notifiers)
    {
        Name = name;
        Notifiers = notifiers;
    }

    public void Notify(string message)
    {
        Notifiers.ForEach(x => x.SendNotification($"{Name}, {message}"));
    }

    public void NotifyWithPriority(string message)
    {
        foreach (var notifier in Notifiers)
        {
            if (notifier.Priority == 1)
            {
                notifier.SendNotification($"{Name}, {message}");
                return;
            }
        }

        foreach (var notifier in Notifiers)
        {
            if (notifier.Priority == 2)
            {
                notifier.SendNotification($"{Name}, {message}");
                return;
            }
        }

        foreach (var notifier in Notifiers)
        {
            if (notifier.Priority == 3)
            {
                notifier.SendNotification($"{Name}, {message}");
                return;
            }
        }
    }
}