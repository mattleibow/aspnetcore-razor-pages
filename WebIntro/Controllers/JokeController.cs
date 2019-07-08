using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebIntro.Services;

namespace WebIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private readonly IJokeService service;

        public JokeController(IJokeService jokeService)
        {
            service = jokeService;
        }

        [HttpGet]
        public Task<string> Get()
        {
            return service.GetRandomJokeAsync();
        }
    }
}
