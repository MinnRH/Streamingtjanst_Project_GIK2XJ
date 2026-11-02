namespace Streamingservice.Contents
{
    public class Season
    {
        // Fungerar som ID, därför required.
        public required int SeasonNumber { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
