namespace Streamingservice.Contents
{
    public class Series : Content
    {
        // Ärver resten från Content, men har en lista med säsonger som är specifikt för serier.
        public List<Season> Seasons { get; set; }
    }
}
