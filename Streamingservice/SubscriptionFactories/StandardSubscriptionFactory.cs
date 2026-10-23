using Streamingservice.SubscriptionDecorators;

namespace Streamingservice;

public class StandardSubscriptionFactory :  SubscriptionFactory
{
    public string SubscriptionLevel => "Standard";
    
    //Wrapar subscription med de korrekta dekoratörerna
    public override ISubscription CreateSubscription()
    {
        ISubscription subscription = new Subscription(SubscriptionLevel);
        subscription = new FullHDQualityDecorator(subscription); //(Vilken vi wrapar)
        subscription = new AdditionalStreamDecorator(subscription, 1); //(Vilken vi wrapar + antal extra skärmar)
        return subscription;
    }
}