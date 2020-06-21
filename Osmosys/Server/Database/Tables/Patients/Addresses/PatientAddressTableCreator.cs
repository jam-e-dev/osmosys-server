using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Addresses
{
    public class PatientAddressTableCreator : IPatientAddressTableCreator
    {
        private readonly DbConnection _connection;

        public PatientAddressTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_addresses (pk bigserial primary key, patient_fk bigint, foreign key (patient_fk) references patients(pk), use text, type text, text text, city text, district text, state text, postal_code text, country text, period_start timestamp, period_end timestamp)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}