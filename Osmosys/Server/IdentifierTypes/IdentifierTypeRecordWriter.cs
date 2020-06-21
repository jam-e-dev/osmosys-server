using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.IdentifierTypes
{
    public class IdentifierTypeRecordWriter : IIdentifierTypeRecordWriter
    {
        private readonly DbConnection _connection;

        public IdentifierTypeRecordWriter(
            DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task WriteAsync(CodeableConcept type)
        {
            var typePk = await WriteAsync(type, _connection.Current);
            await WriteAsync(type.Coding, _connection.Current, typePk);
        }

        private static async Task<long> WriteAsync(CodeableConcept type, NpgsqlConnection connection)
        {
            const string sql = "insert into identifier_types (text) values (@text) returning pk";
            await using var cmd = new NpgsqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("text", type.Text);
            return (long) await cmd.ExecuteScalarAsync();
        }

        private static async Task WriteAsync(Coding[] codings, NpgsqlConnection connection, long typePk)
        {
            foreach (var coding in codings)
            {
                await WriteAsync(coding, connection, typePk);
            }
        }

        private static async Task WriteAsync(Coding coding, NpgsqlConnection connection, long typePk)
        {
            const string sql = "insert into identifier_type_codings (identifier_type_fk, system, version, code, display, user_selected) VALUES (@identifierTypePk, @system, @version, @code, @display, @userSelected)";
            await using var cmd = new NpgsqlCommand(sql, connection);
            
            var cmdParams = cmd.Parameters;
            cmdParams.AddWithValue("identifierTypePk", typePk);
            cmdParams.AddWithValue("system", coding.System);
            cmdParams.AddWithValue("version", coding.Version);
            cmdParams.AddWithValue("code", coding.Code);
            cmdParams.AddWithValue("display", coding.Display);
            cmdParams.AddWithValue("userSelected", coding.UserSelected);
            
            await cmd.ExecuteNonQueryAsync();
        }
    }
}