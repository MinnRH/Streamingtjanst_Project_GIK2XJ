namespace Streamingservice;

public class BasicSubscriptionFactory :  SubscriptionFactory
{
    public string SubscriptionLevel => "Basic";
    public int Price => 89;
    public override ISubscription CreateSubscription() => new Subscription(SubscriptionLevel, Price);
}