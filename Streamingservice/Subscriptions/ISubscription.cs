namespace Streamingservice;

public interface ISubscription
{
    public string SubscriptionLevel { get; }
    public int NumberOfStreams { get; }
    public string VideoQuality { get; }
}