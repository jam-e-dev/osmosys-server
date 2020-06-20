using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Init
{
    public class DbVerifier : IDbVerifier
    {
        private readonly ServerConnection _connection;

        public DbVerifier(ServerConnection connection)
        {
            _connection = connection;
        }
        
        public async Task<bool> VerifyAsync()
        {
            const string sql = "select datname from pg_catalog.pg_database WHERE datname = @dbName";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            cmd.Parameters.AddWithValue("dbName", Db.Name);
            await using var reader = await cmd.ExecuteReaderAsync();
            return await reader.ReadAsync();
        }
    }
}