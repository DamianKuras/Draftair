using System.Data;

namespace Draftair.DAL.Factories
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}