namespace Streamingservice;

public class Subscription(string subscriptionLevel)
{
    // Properties
    public string SubscriptionLevel { get; init; } = subscriptionLevel;
    public string VideoQuality { get; set; }
    public int NumberOfStreams { get; set; }
}