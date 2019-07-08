using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebIntro.Services;

namespace WebIntro.Pages
{
    public class BrowseDadJokesModel : PageModel
    {
        private readonly IJokeService service;

        public BrowseDadJokesModel(IJokeService jokeService)
        {
            service = jokeService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; }

        public string[] Jokes { get; set; }

        public int TotalPages { get; set; }

        public async Task OnGetAsync()
        {
            await DoSearchAsync();
        }

        public async Task OnPostAsync()
        {
            await DoSearchAsync();
        }

        private async Task DoSearchAsync()
        {
            var results = await service.SearchJokesAsync(SearchTerm, PageNumber);

            PageNumber = results.CurrentPage;
            TotalPages = results.TotalPages;

            Jokes = results.Jokes;
        }
    }
}
