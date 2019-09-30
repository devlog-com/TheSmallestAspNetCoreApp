using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace TheSmallestAspNetCoreApp
{
    public class Program
    {
        public static Task Main()
        {
            var hostBuilder = new HostBuilder();

            hostBuilder.ConfigureWebHost(webHostBuilder =>
            {
                webHostBuilder.UseKestrel();

                webHostBuilder.Configure(appBuilder =>
                    {
                        appBuilder.Use((ctx, next) => ctx.Response.WriteAsync("Hello world!"));
                    });
            });


            return hostBuilder.Build().RunAsync();
        }
    }
}
