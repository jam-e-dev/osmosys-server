using DataAccess.Connections;
using Npgsql;

namespace DataAccess.Implementation.Sql
{
    public class TableBuilderFactory
    {
        private readonly IDbConnection<NpgsqlConnection> _dbConnection;

        public TableBuilderFactory(IDbConnection<NpgsqlConnection> dbConnection)
        {
            _dbConnection = dbConnection;
        }
        
        public TableBuilder Create(string tableName) => new TableBuilder(tableName, _dbConnection); 
    }
}