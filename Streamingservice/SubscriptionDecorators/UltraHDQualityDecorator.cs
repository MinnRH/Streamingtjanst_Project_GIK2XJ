namespace Streamingservice.SubscriptionDecorators;

public class UltraHDQualityDecorator(ISubscription subscription) : BaseSubscriptionDecorator(subscription)
{
    // Skriver över propertyn för att returnera "UHD" i stället för standardvärdet "HD". 
    public override string VideoQuality => "UHD";
}