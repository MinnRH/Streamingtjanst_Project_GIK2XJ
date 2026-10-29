using Microsoft.AspNetCore.Mvc;
using Streamingservice.Contents;
using Streamingservice.ObserverPatternInterfaces;
using Streamingservice.Users;

namespace Streamingservice.Controllers
{
    public class PlayContentSelectionController : Controller, IPlaySubject
    {
        public IActionResult PlayContent(int selectedContentId)
        {
            ViewBag.User = UserDataBase.Users.FirstOrDefault(user => user.UserEmail == UserDataBase.currentUser.UserEmail);
            Content selectedContent = ContentDataBase.ContentList.FirstOrDefault(content => content.Id == selectedContentId);
            NotifyObservers(selectedContent.Id, selectedContent.Genre);
            return View("ContentPlayer", selectedContent);
        }


        public List<IPlayObserver> observers = new List<IPlayObserver>(){ UserDataBase.currentUser };
        public void AddObserver(IPlayObserver observer) 
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IPlayObserver observer) 
        {
            observers.Remove(observer);
        }
        public void NotifyObservers(int contentId, Genre genre) 
        { 
            foreach (IPlayObserver observer in observers)
            {
                observer.Update(contentId, genre);
            }
        }
    }
}
