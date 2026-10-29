using Streamingservice.Contents;
using Streamingservice.SubscriptionDecorators;

namespace Streamingservice.Users
{
    public static class AccessControlService
    {
        public static bool CheckContentAccess(Content content, User currentUser)
        {
            if (currentUser.UserSubscriptionLevel is not NonSubscription)
            {
                if (content.IsExclusive)
                {
                    if (currentUser.UserSubscriptionLevel is ExclusiveContentDecorator)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
