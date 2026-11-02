namespace Streamingservice.SubscriptionDecorators;

public class FullHDQualityDecorator(ISubscription subscription) : BaseSubscriptionDecorator(subscription)
{
    // Skriver över propertyn för att returnera "FHD" i stället för standardvärdet "HD". 
    public override string VideoQuality => "FHD";
}