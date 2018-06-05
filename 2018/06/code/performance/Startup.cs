using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;

namespace netcore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // START OMIT
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(logging =>
                logging.AddFilter("Microsoft", LogLevel.None)
            )
            .UseStartup<Startup>().Build().Run();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var routeBuilder = new RouteBuilder(app);
            routeBuilder.MapGet("endpoint", context =>
            {
                return context.Response.WriteAsync("Success");
            }).Build();
            var routes = routeBuilder.Build();
            app.UseRouter(routes);
        }
        //END OMIT
    }
}