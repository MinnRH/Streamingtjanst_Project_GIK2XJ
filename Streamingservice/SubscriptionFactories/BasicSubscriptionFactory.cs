namespace Streamingservice;

public class BasicSubscriptionFactory :  SubscriptionFactory
{
    public string SubscriptionLevel => "Basic";
    public override ISubscription CreateSubscription() => new Subscription(SubscriptionLevel);
}

//Hej :)

// Jonas Säger också hej