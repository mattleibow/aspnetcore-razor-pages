using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace WebIntro
{
    public class Program
    {
        public static void Main(string[] args) => WebHost
            .CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build()
            .Run();
    }

    public class Startup
    {
        public void Configure(IApplicationBuilder app) => app
            .UseHttpsRedirection()
            .UseDefaultFiles()
            .UseStaticFiles();
    }
}
