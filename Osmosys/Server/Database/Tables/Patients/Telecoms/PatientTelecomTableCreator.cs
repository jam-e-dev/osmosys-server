using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Telecoms
{
    public class PatientTelecomTableCreator : IPatientTelecomTableCreator
    {
        private readonly DbConnection _connection;

        public PatientTelecomTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_telecoms (pk bigserial primary key, patient_fk bigint, foreign key patient_fk references patients(pk), system text, value text, use text, rank int, period_start timestamp, period_end timestamp)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}