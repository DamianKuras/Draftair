using System.Data;
using Microsoft.Data.Sqlite;

namespace Draftair.DAL.Factories
{
    public class SqliteDbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public SqliteDbConnectionFactory(string connectionString)
        {
            _connectionString =
                connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public IDbConnection CreateConnection()
        {
            var connection = new SqliteConnection(_connectionString);
            return connection;
        }
    }
}
