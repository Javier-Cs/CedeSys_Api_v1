using Microsoft.Data.SqlClient;
using System.Data;

namespace CedeSys_Api_v1.Data
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _connectionString;

        public SqlConnectionFactory(IConfiguration config) { 
            _connectionString = config.GetConnectionString("SqlServerConnection")
                ?? throw new ArgumentNullException(nameof(config));
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
