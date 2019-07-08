using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ICanHazDadJoke.NET;

namespace WebIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private readonly DadJokeClient client =
            new DadJokeClient("WebIntro", "https://github.com/mattleibow/aspnetcore-razor-pages");

        [HttpGet]
        public Task<string> Get()
        {
            return client.GetRandomJokeStringAsync();
        }
    }
}
