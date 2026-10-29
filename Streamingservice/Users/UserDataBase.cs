using System.Collections.Generic;
using Streamingservice.Contents;
namespace Streamingservice.Users;

public static class UserDataBase
{

    // Hårdkodad befintlig användare.
    public static ConcreteUser currentUser = new ConcreteUser
    {
        UserEmail = "123@abc",
        WatchedContentIds = new HashSet<int>(),
        RecentlyWatched = new CircularBuffer<Genre>(5),
        UserSubscriptionLevel = new NonSubscription()
    };

    public static List<User> Users = new List<User>
    {
        currentUser
    };
}
