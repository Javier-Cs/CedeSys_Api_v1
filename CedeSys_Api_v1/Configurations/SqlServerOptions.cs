namespace CedeSys_Api_v1.Configurations
{
    public sealed class SqlServerOptions
    {
        public const string SectionName = "ConnectionStrings";

        public string SqlServerConnection { get; init; } = string.Empty;
    }
}
