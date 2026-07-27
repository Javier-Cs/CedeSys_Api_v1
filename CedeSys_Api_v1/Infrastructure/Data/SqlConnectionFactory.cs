using CedeSys_Api_v1.Configurations;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace CedeSys_Api_v1.Infrastructure.Data
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _connectionString;

        /*
        public SqlConnectionFactory(IConfiguration config) { 
            _connectionString = config.GetConnectionString("SqlServerConnection")
                ?? throw new ArgumentNullException(nameof(config));
        }
        */


        // antes tomavamos el valor de appseting pero ahora lo tomamos del option correspondiente y lo validamos 
        public SqlConnectionFactory(IOptions<SqlServerOptions> options) {
            _connectionString = options.Value.SqlServerConnection;

            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión SqlServerConnection no está configurada.");
            }
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
