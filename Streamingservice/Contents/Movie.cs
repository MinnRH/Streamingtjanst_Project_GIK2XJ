namespace Streamingservice.Contents
{
    public class Movie : Content
    {
        // Ärver från Content, därför endast PlayTime som är nytt för filmer, men inte för serier.
        public int PlayTime { get; set; }
    }
}
