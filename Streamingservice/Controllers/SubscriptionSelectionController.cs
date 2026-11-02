using Microsoft.AspNetCore.Mvc;
using Streamingservice.Models;
using System.Diagnostics;
using System.Linq;

using Streamingservice.Users;

namespace Streamingservice.Controllers;

public class SubscriptionSelectionController : Controller 
{
    public IActionResult SubscriptionViewSelection(string selectedAction)
    {

        if (selectedAction == "ChangeSubscription")
        {
            return View("Index");
        }
        else if (selectedAction == "ViewSubscription")
        {

            User currentUser = UserDataBase.Users
            .FirstOrDefault(user => user.UserEmail == UserDataBase.currentUser.UserEmail);

            ISubscription subscription = currentUser.UserSubscriptionLevel;

            return View("SubscriptionDetails", subscription);
        }
        else
        {
            return NotFound();
        }
    }
    
    public IActionResult SelectSubscription(string selection)
    {
        SubscriptionFactory factory = selection switch
        {
            "Basic" => new BasicSubscriptionFactory(),
            "Standard" => new StandardSubscriptionFactory(),
            "Premium" => new PremiumSubscriptionFactory()
        };

        ISubscription subscription = factory.CreateSubscription();
        
        User currentUser = UserDataBase.Users
        .FirstOrDefault(user => user.UserEmail == UserDataBase.currentUser.UserEmail);
        
        if (currentUser != null)
        {
            currentUser.SetUserSubscriptionLevel(subscription);
        }
        
        return View("SubscriptionDetails", subscription);
    }  
}
