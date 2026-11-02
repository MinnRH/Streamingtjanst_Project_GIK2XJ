namespace Streamingservice.SubscriptionDecorators;

// Antalet extra strömmar sätts via en konstruktorparameter för att olika instanser kan ha olika antal extra strömmar.
public class AdditionalStreamDecorator(ISubscription subscription, int numberOfExtraStreams) : BaseSubscriptionDecorator(subscription)
{
    public override int NumberOfStreams => _baseSubscription.NumberOfStreams +  numberOfExtraStreams;
}