namespace Streamingservice.Content
{
    public class Series : Content
    {
        public List<Season> Seasons { get; set; } = new List<Season>();
    }
}
