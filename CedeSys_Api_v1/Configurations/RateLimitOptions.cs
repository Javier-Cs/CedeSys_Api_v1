namespace CedeSys_Api_v1.Configurations
{
    public sealed class RateLimitOptions
    {
        public const string SectionName = "RateLimit";

        public int PermitPerMinute { get; init; }
        public int WindowMinutes { get; init; }
        public int QueueLimit { get; init; }
    }
}
