using Microsoft.AspNetCore.Mvc;
using Streamingservice.Contents;


namespace Streamingservice.Controllers
{
    public class ContentSelectionController : Controller
    {
        public IActionResult SelectContent (int selectedContentId)
        {
            Content selectedContent = ContentDataBase.ContentList
            .FirstOrDefault(content => content.Id == selectedContentId);
            if (selectedContent == null) { return NotFound(); }

            if (selectedContent is Movie) { return View("MovieDetailDisplay", selectedContent); }
            else { return View("SeriesDetailDisplay", selectedContent); }
        }
    }
}
