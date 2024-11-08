public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddScoped<IVtexHealthClient, VtexHealthClient>();
        services.AddScoped<VTEXWrapper>();
    }

}
