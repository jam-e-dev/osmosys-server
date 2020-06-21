using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Identifiers
{
    public class PatientIdentifierTableCreator : IPatientIdentifierTableCreator
    {
        private readonly DbConnection _connection;

        public PatientIdentifierTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_identifiers (pk bigserial primary key, patient_fk bigint, foreign key (patient_fk) references patients(pk), use text, identifier_type_fk bigint, foreign key (identifier_type_fk) references identifier_types(pk), system text, value text, period_start timestamp, period_end timestamp)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}