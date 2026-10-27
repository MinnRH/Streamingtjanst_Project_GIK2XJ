namespace Streamingservice.Content
{
    public class Episode
    {
        public string EpisodeTitle { get; set; } = "";
        public required int EpisodeNumber { get; set; }
        public int PlayTime { get; set; }

    }
}
