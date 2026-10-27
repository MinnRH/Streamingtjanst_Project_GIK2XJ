namespace Streamingservice.Content
{
    public class Season
    {
        public required int SeasonNumber { get; set; }

        public List<Episode> Episodes { get; set; } = new List<Episode>();
    }
}
