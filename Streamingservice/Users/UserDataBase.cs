using System.Collections.Generic;
using Streamingservice.Contents;
namespace Streamingservice.Users;

public static class UserDataBase
{

    // Hårdkodad befintlig användare för att kunna köra programmet utan riktig inloggningsfunktionalitet.
    public static ConcreteUser currentUser = new ConcreteUser
    {
        UserEmail = "123@abc",
        WatchedContentIds = new HashSet<int>(),
        RecentlyWatched = new CircularBuffer<Genre>(5),
        UserSubscriptionLevel = new NonSubscription()
    };
    // Listan är statiskt för att kunna nås från andra klasser utan att behöva instansiera UserDataBase.
    public static List<User> Users = new List<User>
    {
        currentUser
    };
}
