namespace Streamingservice.SubscriptionDecorators;

public class AdditionalStreamDecorator(ISubscription subscription, int numberOfExtraStreams) : BaseSubscriptionDecorator(subscription)
{
    public override int NumberOfStreams => _baseSubscription.NumberOfStreams +  numberOfExtraStreams;
}