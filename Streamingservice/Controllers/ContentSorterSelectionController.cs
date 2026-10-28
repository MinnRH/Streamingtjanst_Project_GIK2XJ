using Microsoft.AspNetCore.Mvc;
using Streamingservice.Contents;

namespace Streamingservice.Controllers
{
    public class ContentSorterSelectionController : Controller
    {
        public IActionResult Library()
        {
            List<Content> sortedContentList = ContentSorter.SortContentByTitle(ContentDataBase.ContentList);
            return View("ByTitleDisplay", sortedContentList);
        }
    }
}
