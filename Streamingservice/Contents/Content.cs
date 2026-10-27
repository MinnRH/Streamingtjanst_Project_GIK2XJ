namespace Streamingservice.Contents
{
    public abstract class Content
    {
        public required int Id { get; init; }
        public required string Title { get; set; }
        public string Description { get; set; } = "No description";
        public required Genre Genre { get; set; }
        public bool IsExclusive { get; set; } = false;
    }
}
