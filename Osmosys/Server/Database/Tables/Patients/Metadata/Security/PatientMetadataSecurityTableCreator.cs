using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Metadata.Security
{
    public class PatientMetadataSecurityTableCreator : IPatientMetadataSecurityTableCreator
    {
        private readonly DbConnection _connection;

        public PatientMetadataSecurityTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_metadata_security_codings (pk bigserial primary key, patient_metadata_fk bigint, foreign key (patient_metadata_fk) references patient_metadata(pk), system text, version text, code text, display text, user_selected boolean)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}