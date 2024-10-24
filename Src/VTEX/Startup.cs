using Microsoft.Extensions.DependencyInjection;
using VTEX.Clients.Catalog;
using VTEX.Clients.Catalog.Contracts;

namespace VTEX
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISkuEanClient, SkuEanClient>();
        }
    }
}
