using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ICanHazDadJoke.NET;

namespace WebIntro.Pages
{
    public class BrowseDadJokesModel : PageModel
    {
        private readonly DadJokeClient client =
            new DadJokeClient("WebIntro", "https://github.com/mattleibow/aspnetcore-razor-pages");

        public string SearchTerm { get; set; }

        public string[] Jokes { get; set; }

        public async Task OnGetAsync()
        {
            var results = await client.SearchJokesAsync(SearchTerm, 1, 10);

            Jokes = results.Results.Select(j => j.Joke).ToArray();
        }
    }
}
