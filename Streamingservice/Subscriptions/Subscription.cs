namespace Streamingservice;

public class Subscription(string subscriptionLevel, int price) : ISubscription
{
    // Sätter standardvärden som används om de inte skrivs över via dekoratörer.
    public string SubscriptionLevel { get; init; } = subscriptionLevel;
    public string VideoQuality { get; init; } = "HD";
    public int NumberOfStreams { get; init; } = 1;
    public int Price { get; set; } = price;
}