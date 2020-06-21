using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.IdentifierTypes
{
    public class IdentifierTypeTableCreator : IIdentifierTypeTableCreator
    {
        private readonly DbConnection _connection;

        public IdentifierTypeTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists identifier_types (pk bigserial primary key, text text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}