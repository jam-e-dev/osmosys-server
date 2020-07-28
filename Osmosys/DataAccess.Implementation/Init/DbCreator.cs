using System.Threading.Tasks;
using DataAccess.Connections;
using DataAccess.Implementation.Connections;
using DataAccess.Init;
using Npgsql;

namespace DataAccess.Implementation.Init
{
    public class DbCreator : IDbCreator
    {
        private readonly IServerConnection<NpgsqlConnection> _connection;

        public DbCreator(IServerConnection<NpgsqlConnection> connection)
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