namespace CedeSys_Api_v1.Configurations
{
    public sealed class ConnectionSqlOptions
    {
        public const string SectionName = "ConnectionStrings";

        public string SqlServerConnection { get; init; } = string.Empty;
    }
}
