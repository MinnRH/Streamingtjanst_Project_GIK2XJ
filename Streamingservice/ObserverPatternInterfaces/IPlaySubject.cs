namespace Streamingservice.ObserverPatternInterfaces
{
    public interface IPlaySubject
    {
        public void AddObserver(IPlayObserver observer) { }
        public void RemoveObserver(IPlayObserver observer) { }
        public void NotifyObservers() { }
    }
}
