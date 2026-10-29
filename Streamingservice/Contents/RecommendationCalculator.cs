

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
                .GroupBy(genre => genre)
                .OrderByDescending(group => group.Count())
                .First()
                .Key;
            }
            else
            {
                mostWatchedGenre = Genre.Action;
            }
            
            return mostWatchedGenre;
        }
    }
}
