using System.Data;

namespace Streamingservice.Users;

public class ConcreteUser : User
{
    public string UserEmail { get; set; }
    public HashSet<int> WatchedContentIds { get; set; }
    public ISubscription UserSubscriptionLevel { get; set; }
    
    public override void Update()
    {
        // Kod här
    }
}