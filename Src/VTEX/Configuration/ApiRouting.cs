using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace VTEX.Configuration
{
    public static class ApiRouting
    {
        public static void ConfigureApiRouting(this IServiceCollection services)
        {
            services.AddControllers();
        }

        public static void UseApiRouting(this IApplicationBuilder app)
        {
            app.UseRouting().UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}