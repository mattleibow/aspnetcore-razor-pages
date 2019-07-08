using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICanHazDadJoke.NET;

namespace WebIntro.Services
{
    public class JokeService : IJokeService
    {
        private readonly DadJokeClient client;

        public JokeService()
        {
            client = new DadJokeClient(
                "WebIntro",
                "https://github.com/mattleibow/aspnetcore-razor-pages");
        }

        public Task<string> GetRandomJokeAsync()
        {
            return client.GetRandomJokeStringAsync();
        }

        public async Task<SearchResult> SearchJokesAsync(string searchTerm, int pageNumber)
        {
            var results = await client.SearchJokesAsync(searchTerm, pageNumber, 10);
            return new SearchResult
            {
                CurrentPage = results.CurrentPage,
                TotalPages = results.TotalPages,
                Jokes = results.Results.Select(j => j.Joke).ToArray()
            };
        }
    }
}
