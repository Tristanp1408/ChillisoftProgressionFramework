namespace SmsApp;

public interface ISmsSender
{
    Task Send(ISmsMessagePayload payload);
}