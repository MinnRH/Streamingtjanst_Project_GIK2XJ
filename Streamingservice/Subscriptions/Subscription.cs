namespace Streamingservice;

public class Subscription(string subscriptionLevel, int price) : ISubscription
{
    // Properties
    public string SubscriptionLevel { get; init; } = subscriptionLevel;
    public string VideoQuality { get; init; } = "HD";
    public int NumberOfStreams { get; init; } = 1;
    public int Price { get; set; } = price;
}