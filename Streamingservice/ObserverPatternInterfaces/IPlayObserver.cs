using Streamingservice.Contents;

namespace Streamingservice.ObserverPatternInterfaces
{
    public interface IPlayObserver
    {
        public void Update(int contentId, Genre genre) { }
    }
}
