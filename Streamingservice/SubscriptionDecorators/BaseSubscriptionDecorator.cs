namespace Streamingservice.SubscriptionDecorators;

public abstract class BaseSubscriptionDecorator(ISubscription subscription) : ISubscription
{
    protected readonly ISubscription _baseSubscription = subscription;
    // Hänvisar alltid till "lagret" under för att få rätt värden, så att dekoratörer kan bygga på varandra.
    public virtual string SubscriptionLevel => _baseSubscription.SubscriptionLevel;
    public virtual string VideoQuality => _baseSubscription.VideoQuality;
    public virtual int NumberOfStreams =>  _baseSubscription.NumberOfStreams;
    public virtual int Price => _baseSubscription.Price;
}