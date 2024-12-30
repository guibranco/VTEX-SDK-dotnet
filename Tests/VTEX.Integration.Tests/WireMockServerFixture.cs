using System;
using WireMock.Server;
using WireMock.Settings;

public class WireMockServerFixture : IDisposable
{
    public WireMockServer Server { get; }

    public WireMockServerFixture()
    {
        Server = WireMockServer.Start(new WireMockServerSettings
        {
            Urls = new[] { "http://localhost:9091" },
            StartAdminInterface = true,
            ReadStaticMappings = true
        });
    }

    public void Dispose() => Server.Stop();
}