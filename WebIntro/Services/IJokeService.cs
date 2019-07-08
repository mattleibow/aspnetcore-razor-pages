using System.Threading.Tasks;

namespace WebIntro.Services
{
    public interface IJokeService
    {
        Task<string> GetRandomJokeAsync();

        Task<SearchResult> SearchJokesAsync(string searchTerm, int pageNumber);
    }
}
