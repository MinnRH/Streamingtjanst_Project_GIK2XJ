using Microsoft.AspNetCore.Mvc;
using Streamingservice.Contents;
using Streamingservice.Users;


namespace Streamingservice.Controllers
{
    public class ContentSelectionController : Controller
    {
        public IActionResult SelectContent (int selectedContentId)
        {
            // Om det inte finns något matchande innehåll visas en NotFound sida för att tydliggöra att innehållet inte finns.
            Content selectedContent = ContentDataBase.ContentList
            .FirstOrDefault(content => content.Id == selectedContentId);
            if (selectedContent == null) { return NotFound(); }

            // User används för att kontrollera om användaren har tillgång att visa innehållet, en bool skickas med i en ViewBag.
            User currentUser = UserDataBase.Users
            .FirstOrDefault(user => user.UserEmail == UserDataBase.currentUser.UserEmail);
            ViewBag.hasAccess = AccessControlService.CheckContentAccess(selectedContent, currentUser);

            // If-sats för att returnera rätt vy beroende på om det valda innehållet är en film eller en serie.
            if (selectedContent is Movie) { return View("MovieDetailDisplay", selectedContent); }
            else { return View("SeriesDetailDisplay", selectedContent); }
        }
    }
}
