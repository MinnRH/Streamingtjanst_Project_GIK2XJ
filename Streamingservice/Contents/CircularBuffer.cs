namespace Streamingservice.Contents
{
    public class CircularBuffer<Genre>(int maxCapacity)
    {
        private readonly Queue<Genre> _queue = new Queue<Genre>(maxCapacity);

        public void Add (Genre genre)
        {
            if (_queue.Count >= maxCapacity)
            {
                _queue.Dequeue();
            }
            _queue.Enqueue(genre);
        }
        public Queue<Genre> GetQueue()
        {
            return _queue;
        }
    }
}
