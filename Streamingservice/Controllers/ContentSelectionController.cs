using Microsoft.AspNetCore.Mvc;
using Streamingservice.Contents;
using Streamingservice.Users;


namespace Streamingservice.Controllers
{
    internal class ContentSelectionController : Controller
    {
        public IActionResult SelectContent (Content selectedContent)
        {
            return View();
        }
    }
}
