using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Metadata.Profiles
{
    public class PatientMetadataProfileTableCreator : IPatientMetadataProfileTableCreator
    {
        private readonly DbConnection _connection;

        public PatientMetadataProfileTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_metadata_profiles (pk bigserial primary key, patient_metadata_fk bigint, foreign key (patient_metadata_fk) references patient_metadata(pk), profile text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}