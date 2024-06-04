namespace SmsApp;

public interface IMessagePayload
{
    List<string> Recipients { get; }
    string Sender { get; }
    string Body { get; }
}