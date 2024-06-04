namespace SmsApp;

public class SmsMessagePayload: ISmsMessagePayload
{
    private SmsMessagePayload()
    {
    }

    public static SmsMessagePayload Create(List<string> recipients, string sender, string body)
    {
        return new SmsMessagePayload
        {
            Recipients = recipients,
            Sender = sender,
            Body = body
        };
    }

    public List<string> Recipients { get; init; }
    public string Sender { get; init; }
    public string Body { get; init; }
}