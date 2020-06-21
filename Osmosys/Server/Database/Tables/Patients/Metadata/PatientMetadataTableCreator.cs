using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Metadata
{
    public class PatientMetadataTableCreator : IPatientMetadataTableCreator
    {
        private readonly DbConnection _connection;

        public PatientMetadataTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_metadata (pk bigserial primary key, version_id text, last_updated timestamp, source text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}