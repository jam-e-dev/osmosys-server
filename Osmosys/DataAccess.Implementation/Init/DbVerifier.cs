using System.Threading.Tasks;
using DataAccess.Connections;
using DataAccess.Implementation.Connections;
using DataAccess.Init;
using Npgsql;

namespace DataAccess.Implementation.Init
{
    public class DbVerifier : IDbVerifier
    {
        private readonly IServerConnection<NpgsqlConnection> _connection;

        public DbVerifier(IServerConnection<NpgsqlConnection> connection)
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