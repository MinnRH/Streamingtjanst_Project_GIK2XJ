using Microsoft.AspNetCore.Mvc;
using Streamingservice.Models;
using System.Diagnostics;
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
        SubscriptionFactory factory = selection switch
        {
            "Basic" => new BasicSubscriptionFactory(),
            "Standard" => new StandardSubscriptionFactory(),
            "Premium" => new PremiumSubscriptionFactory()
        };

        ISubscription subscription = factory.CreateSubscription();

        foreach (User user in UserDataBase.Users )
        {
           user.SetUserSubscriptionLevel(subscription);
        }
        
        return View("SubscriptionDetails", subscription);
    }  
}
