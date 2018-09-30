using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Steeltoe.Extensions.Logging;

namespace Microservice.PoC.PremiumService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:8030")
                .UseStartup<Startup>()
                .ConfigureLogging((builderContext, loggingBuilder) =>
                {
                    loggingBuilder.AddConfiguration(builderContext.Configuration.GetSection("Logging"));
                    // Add Steeltoe Dynamic Logging Provider
                    loggingBuilder.AddDynamicConsole();
                });
    }
}
