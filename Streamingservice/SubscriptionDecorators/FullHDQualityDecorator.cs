namespace Streamingservice.SubscriptionDecorators;

public class FullHDQualityDecorator(ISubscription subscription) : BaseSubscriptionDecorator(subscription)
{
    // För att få videokvaliten att returnera "FHD" med get metoden istället för "HD" skrivs den över. 
    public override string VideoQuality => "FHD";
}