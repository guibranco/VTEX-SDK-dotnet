namespace VTEXIntegration
{
    public static class VTEXFeedV3Config
    {
        // Replace with your actual VTEX API key
        public static string ApiKey => Environment.GetEnvironmentVariable("VTEX_API_KEY") ?? throw new ArgumentNullException("VTEX_API_KEY");

        // Replace with your actual VTEX API token
        public static string ApiToken => Environment.GetEnvironmentVariable("VTEX_API_TOKEN") ?? throw new ArgumentNullException("VTEX_API_TOKEN");

        // VTEX account name
        public const string AccountName = "your-account";
}
