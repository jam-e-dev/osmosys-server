using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.IdentifierTypes
{
    public class IdentifierTypeRecordReader : IIdentifierTypeRecordReader
    {
        private readonly DbConnection _connection;

        public IdentifierTypeRecordReader(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task<long> CountAsync()
        {
            const string sql = "select count(*) from identifier_types";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            return (long) await cmd.ExecuteScalarAsync();
        }
    }
}