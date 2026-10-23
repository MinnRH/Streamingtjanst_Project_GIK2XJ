namespace Streamingservice.Users;

public abstract class User
{
    public string UserEmail { get; set; }
    public HashSet<int> WatchedContentIds { get; set; }
    public ISubscription UserSubscriptionLevel { get; set; }

    public virtual void Update()
    {
        //Kod här
    }

    public void SetUserSubscriptionLevel(ISubscription subscription)
    {
        UserSubscriptionLevel = subscription;
    }
}