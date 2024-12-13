using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using VTEX.Configuration;

namespace VTEX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices(services => services.ConfigureApiRouting());
                    webBuilder.Configure(app => app.UseApiRouting());
                });
    }
}
