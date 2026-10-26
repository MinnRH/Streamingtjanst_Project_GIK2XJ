using System.Collections.Generic;
namespace Streamingservice.Users;

public static class UserDataBase
{
    public static List<User> Users = new List<User>
    {
        new ConcreteUser
        {
           UserEmail = "123@abc",
           WatchedContentIds = new HashSet<int>(),
           UserSubscriptionLevel = new NonSubscription()
        }
    };
}
