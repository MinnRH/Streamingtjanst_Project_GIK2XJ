namespace Streamingservice;

public class NonSubscription : ISubscription
{
    public string SubscriptionLevel { get; } = "n/a";
    public int NumberOfStreams { get; } = 0;
    public string VideoQuality { get; } = "n/a";
    public int Price { get; } = 0;
}