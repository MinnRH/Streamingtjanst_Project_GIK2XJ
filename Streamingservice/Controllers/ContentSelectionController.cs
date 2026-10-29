using Microsoft.AspNetCore.Mvc;
using Streamingservice.Contents;
using Streamingservice.Users;


namespace Streamingservice.Controllers
{
    public class ContentSelectionController : Controller
    {
        public IActionResult SelectContent (int selectedContentId)
        {
            Content selectedContent = ContentDataBase.ContentList
            .FirstOrDefault(content => content.Id == selectedContentId);
            if (selectedContent == null) { return NotFound(); }

            User currentUser = UserDataBase.Users
            .FirstOrDefault(user => user.UserEmail == UserDataBase.currentUserEmail);
            ViewBag.hasAccess = AccessControlService.CheckContentAccess(selectedContent, currentUser);

            if (selectedContent is Movie) { return View("MovieDetailDisplay", selectedContent); }
            else { return View("SeriesDetailDisplay", selectedContent); }
        }
    }
}
