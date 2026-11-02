

namespace Streamingservice.Contents
{
    public static class RecommendationCalculator
    {
        public static Genre CalculateRecommendations(CircularBuffer<Genre> recentlyWatched)
        {
            Genre mostWatchedGenre;
            if (recentlyWatched.GetQueue().Count > 0)
            {
                mostWatchedGenre = recentlyWatched
                .GetQueue()
                .GroupBy(genre => genre) // Grupperar genrer för att välja ut den med flest förekomster.
                .OrderByDescending(group => group.Count())
                .First()
                .Key; // Plockar ut värdet (genren) från den grupp som har flest förekomster.
            }
            else
            {
                // Action är default genre för att säkerställa att det alltid finns en rekommendation.
                mostWatchedGenre = Genre.Action;
            }
            
            return mostWatchedGenre;
        }
    }
}
