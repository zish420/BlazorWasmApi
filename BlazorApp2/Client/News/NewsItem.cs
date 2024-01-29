using Microsoft.AspNetCore.Components;

namespace BlazorApp2.Client.News
{
    public class NewsItem
    {
        public string Headline { get; set; }
        public MarkupString Body { get; set; }
        public string ImageUrl { get; set; }
    }
}
