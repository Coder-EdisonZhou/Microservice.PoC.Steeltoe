using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Steeltoe.Extensions.Configuration.ConfigServer;

namespace Microservice.PoC.AgentService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.AddConfigServer()  // Add config server via steeltoe
                .UseUrls("http://*:8010")
                .UseStartup<Startup>();
    }
}
