using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Init
{
    public class DbCreator : IDbCreator
    {
        private readonly ServerConnection _connection;

        public DbCreator(ServerConnection connection)
        {
            _connection = connection;
        }

        public async Task CreateAsync()
        {
            var sql = $"create database {Db.Name}";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}