namespace Streamingservice.Contents
{
    public class Season
    {
        public required int SeasonNumber { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
