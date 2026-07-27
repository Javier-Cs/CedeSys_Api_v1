using System.Data;

namespace CedeSys_Api_v1.Infrastructure.Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
