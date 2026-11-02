namespace Streamingservice.SubscriptionDecorators;

public class ExclusiveContentDecorator(ISubscription subscription) : BaseSubscriptionDecorator(subscription)
{
    // Är tom för att det endast spelar någon roll om prenumerationstypen är ExclusiveContent
    // eller inte. Alltså behövs ingen extra logik här.
}