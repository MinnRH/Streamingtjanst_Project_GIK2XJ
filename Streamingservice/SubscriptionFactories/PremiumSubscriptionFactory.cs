using Streamingservice.SubscriptionDecorators;

namespace Streamingservice;

public class PremiumSubscriptionFactory : SubscriptionFactory
{
    public string SubscriptionLevel => "Premium";
    
    //Wrapar subscription med de korrekta dekoratörerna
    //För att ge paketet rätt access och värden
    public override ISubscription CreateSubscription()
    {
        ISubscription subscription = new Subscription(SubscriptionLevel);
        subscription = new UltraHDQualityDecorator(subscription); //(Vilken vi wrapar)
        subscription = new AdditionalStreamDecorator(subscription, 2); //(Vilken vi wrapar + antal extra skärmar)
        subscription = new ExclusiveContentDecorator(subscription);
        return subscription;
    }
}