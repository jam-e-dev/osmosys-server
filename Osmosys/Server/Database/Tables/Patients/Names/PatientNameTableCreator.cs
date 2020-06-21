using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Names
{
    public class PatientNameTableCreator : IPatientNameTableCreator
    {
        private readonly DbConnection _connection;

        public PatientNameTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_names (pk bigserial primary key, patient_fk bigint, foreign key (patient_fk) references patients(pk), use text, text text, family text, period_start timestamp, period_end timestamp)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}