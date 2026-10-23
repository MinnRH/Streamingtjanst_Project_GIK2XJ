namespace Streamingservice.SubscriptionDecorators;

public class UltraHDQualityDecorator(ISubscription subscription) : BaseSubscriptionDecorator(subscription)
{
    // För att få videokvaliten att returnera "UHD" med get metoden istället för "HD" skrivs den över.
    public override string VideoQuality => "UHD";
}