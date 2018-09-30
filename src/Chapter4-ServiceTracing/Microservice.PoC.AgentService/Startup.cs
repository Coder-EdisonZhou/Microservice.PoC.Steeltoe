using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pivotal.Discovery.Client;
using Steeltoe.Management.Exporter.Tracing;
using Steeltoe.Management.Tracing;

namespace Microservice.PoC.AgentService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add Steeltoe Discovery Client service
            services.AddDiscoveryClient(Configuration);
            // Add Steeltoe Distributed Tracing
            services.AddDistributedTracing(Configuration);
            // Export traces to Zipkin
            services.AddZipkinExporter(Configuration);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            // Add Steeltoe Discovery Client service
            app.UseDiscoveryClient();
            // Start up trace exporter
            app.UseTracingExporter();
        }
    }
}
