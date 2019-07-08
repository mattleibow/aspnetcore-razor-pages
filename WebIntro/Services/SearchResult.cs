namespace WebIntro.Services
{
    public class SearchResult
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public string[] Jokes { get; set; }
    }
}
