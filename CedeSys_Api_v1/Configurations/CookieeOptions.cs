namespace CedeSys_Api_v1.Configurations
{
    public sealed class CookieeOptions
    {
        public const string SectionName = "Cookie";

        public string AccessCookieName { get; init; } = string.Empty;
        public string RefreshCookieName { get; init; } = string.Empty;

    }
}
