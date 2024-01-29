namespace BlazorApp2.Client.News
{
    public interface INewsService
    {
        Task<List<NewsItem>> GetNews();
    }
}
