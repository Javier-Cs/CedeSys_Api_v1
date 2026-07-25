namespace CedeSys_Api_v1.Configurations
{
    public sealed class AuthenticationOptions
    {
        public const string SectionName = "Authentication";

        public int MaxFailedAttemptsPerEmail { get; init; }
        public int MaxFailedAttemptsPerIp { get; init; }
        public int BlockMinutesEmail { get; init; }
        public int BlockMinutesIp { get; init; }
    }
}
