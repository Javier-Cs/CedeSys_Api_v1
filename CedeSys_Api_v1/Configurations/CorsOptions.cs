namespace CedeSys_Api_v1.Configurations
{
    public sealed class CorsOptions
    {
        public const string sectionName = "Cors";

        public string[] AllowedOrigins { get; init; } = [];
    }
}
