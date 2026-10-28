using Microsoft.AspNetCore.Mvc;
using Streamingservice.Models;
using System.Diagnostics;
using System.Linq;

using Streamingservice.Users;

namespace Streamingservice.Controllers;

public class SubscriptionSelectionController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult SelectSubscription(string selection)
    {
        string currentUserEmail = "123@abc"; // Hårdkodad email för befintlig användare.
        
        SubscriptionFactory factory = selection switch
        {
            "Basic" => new BasicSubscriptionFactory(),
            "Standard" => new StandardSubscriptionFactory(),
            "Premium" => new PremiumSubscriptionFactory()
        };

        ISubscription subscription = factory.CreateSubscription();
        
        User currentUser = UserDataBase.Users
        .FirstOrDefault(user => user.UserEmail == currentUserEmail);
        
        if (currentUser != null)
        {
            currentUser.SetUserSubscriptionLevel(subscription);
        }
        
        return View("SubscriptionDetails", subscription);
    }  
}
