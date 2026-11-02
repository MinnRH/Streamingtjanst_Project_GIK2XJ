namespace Streamingservice;

public abstract class SubscriptionFactory
{
    public string SubscriptionLevel { get; set; }
    public int Price { get; set; }
    public abstract ISubscription CreateSubscription();
}