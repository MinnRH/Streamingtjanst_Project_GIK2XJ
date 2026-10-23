namespace Streamingservice.SubscriptionDecorators;

public abstract class BaseSubscriptionDecorator(ISubscription subscription) : ISubscription
{
    // Properties
    protected readonly ISubscription _baseSubscription = subscription;
    
    public virtual string SubscriptionLevel => _baseSubscription.SubscriptionLevel;
    public virtual string VideoQuality => _baseSubscription.VideoQuality;
    public virtual int NumberOfStreams =>  _baseSubscription.NumberOfStreams;
}