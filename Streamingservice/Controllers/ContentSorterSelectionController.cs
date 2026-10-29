using Microsoft.AspNetCore.Mvc;
using Streamingservice.Contents;
using Streamingservice.Users;


namespace Streamingservice.Controllers
{
    public class ContentSorterSelectionController : Controller
    {
        public IActionResult ShowLibrary()
        {
            List<Content> sortedContentList = ContentSorter.SortContentByTitle(ContentDataBase.ContentList);
            ViewBag.Label = "Library";
            return View("ContentDisplay", sortedContentList);
        }
        public IActionResult ShowGenre(Genre selectedGenre)
        {
            List<Content> sortedContentList = ContentSorter.SortContentByGenre(ContentDataBase.ContentList, selectedGenre);
            ViewBag.Label = selectedGenre.ToString();
            return View("ContentDisplay", sortedContentList);
        }
        public IActionResult ShowRecommendation()
        {
            User currentUser = UserDataBase.Users
            .FirstOrDefault(user => user.UserEmail == UserDataBase.currentUserEmail);

            Genre selectedGenre = Genre.Action; //<- ändra när RecommendationCalculator är på plats
            List<Content> sortedContentList = ContentSorter.SortContentByRecommendation(ContentDataBase.ContentList, selectedGenre, currentUser);
            ViewBag.Label = "Recommendations";
            return View("ContentDisplay", sortedContentList);
        }
        public IActionResult ShowWatchHistory()
        {
            User currentUser = UserDataBase.Users
            .FirstOrDefault(user => user.UserEmail == UserDataBase.currentUserEmail);

            List<Content> sortedContentList = ContentSorter.SortContentByWatchHistory(ContentDataBase.ContentList, currentUser);
            ViewBag.Label = "Watch History";
            return View("ContentDisplay", sortedContentList);
        }

        public IActionResult ShowByType(string selectedType)
        {
            List <Content> sortedContentList = ContentSorter.SortContentByType(ContentDataBase.ContentList, selectedType);
            ViewBag.Label = selectedType;
            return View("ContentDisplay", sortedContentList);
        }

    }
}
