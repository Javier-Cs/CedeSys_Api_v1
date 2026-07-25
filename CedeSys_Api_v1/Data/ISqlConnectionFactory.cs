using System.Data;

namespace CedeSys_Api_v1.Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
