using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.IdentifierTypes
{
    public class IdentifierTypeCodingTableCreator : IIdentifierTypeCodingTableCreator
    {
        private readonly DbConnection _connection;

        public IdentifierTypeCodingTableCreator(DbConnection connection)
        {
            _connection = connection;
        }

        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists identifier_types (p bigserial primary key, identifier_type_fk bigint, foreign key (identifier_type_fk) references identifier_type(pk), system text, version text, code text, display text, user_selected boolean)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}