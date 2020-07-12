using System.Threading.Tasks;
using Common.DataTypes;
using DataAccess.Implementation.Connection;
using DataAccess.Patients.Identifiers;
using DataAccess.Patients.Identifiers.Types;
using Npgsql;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeRecordWriter : IIdentifierTypeRecordWriter
    {
        private readonly DbDatabaseConnection _databaseConnection;

        public IdentifierTypeRecordWriter(
            DbDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        
        public async Task WriteAsync(CodeableConcept type)
        {
            var typePk = await WriteAsync(type, _databaseConnection.Current);
            await WriteAsync(type.Coding, _databaseConnection.Current, typePk);
        }

        private static async Task<long> WriteAsync(CodeableConcept type, NpgsqlConnection connection)
        {
            //TODO Refactor into command builder.
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
            //TODO Refactor into command builder.
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