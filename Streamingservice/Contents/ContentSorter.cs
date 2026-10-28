using Streamingservice.Users;
namespace Streamingservice.Contents
{
public static class ContentSorter
    {
        public static List<Content> SortContentByTitle(List<Content> unsortedContentList)
        {
            List<Content> sortedByTitleList = unsortedContentList
            .OrderBy(content => content.Title)
            .ToList();
            return sortedByTitleList;
        }
        public static List<Content> SortContentByGenre(List<Content> unsortedContentList, Genre genre)
        {      
            List<Content> sortedByGenreList = unsortedContentList
            .Where(content => content.Genre == genre)
            .OrderBy(content => content.Title)
            .ToList();
            return sortedByGenreList;
        }
        public static List<Content> SortContentByRecommendation(List<Content> unsortedContentList, Genre genre, User user)
        {
            List<Content> sortedByRecommendationList = unsortedContentList
            .Where(content => content.Genre == genre && !user.WatchedContentIds.Contains(content.Id))  
            .OrderBy(content => content.Title)
            .ToList();
            return sortedByRecommendationList;
        }
        public static List<Content> SortContentByWatchHistory(List<Content> unsortedContentList, Genre genre, User user)
        {
            List<Content> sortedByWatchHistoryList = unsortedContentList
            .Where(content => user.WatchedContentIds.Contains(content.Id))
            .OrderBy(content => content.Title)
            .ToList();
            return sortedByWatchHistoryList;
        }
        public static List<Content> SortContentByType(List<Content> unsortedContentList, Content contentChoice)
        {
            List<Content> sortedByTypeList = unsortedContentList
            .Where(content => content.GetType() == contentChoice.GetType())
            .OrderBy(content => content.Title)
            .ToList();
            return sortedByTypeList;
        }
    }
}
