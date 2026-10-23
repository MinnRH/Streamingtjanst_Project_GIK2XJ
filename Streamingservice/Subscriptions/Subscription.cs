namespace Streamingservice;

public class Subscription(string subscriptionLevel) : ISubscription
{
    // Properties
    public string SubscriptionLevel { get; init; } = subscriptionLevel;
    public string VideoQuality { get; init; } = "HD";
    public int NumberOfStreams { get; init; } = 1;
}