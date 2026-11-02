using Streamingservice.Contents;
using Streamingservice.ObserverPatternInterfaces;
using System;

namespace Streamingservice.Users;

public abstract class User : IPlayObserver
{
    public string UserEmail { get; set; }
    public HashSet<int> WatchedContentIds { get; set; }
    public CircularBuffer<Genre> RecentlyWatched { get; set; }
    public ISubscription UserSubscriptionLevel { get; set; }

    public virtual void Update(int contentId, Genre genre)
    {
        // Uppdaterar visningshistoriken för att kunna visa upp och räkna rekommendationer med.
        WatchedContentIds.Add(contentId);
        RecentlyWatched.Add(genre);
    }

    public void SetUserSubscriptionLevel(ISubscription subscription)
    {
        UserSubscriptionLevel = subscription;
    }
}