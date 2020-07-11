using System.Threading.Tasks;
using DataAccess.Implementation.Connection;
using DataAccess.Patients.Addresses;
using Npgsql;

namespace DataAccess.Implementation.Patients.Contacts.Addresses
{
    public class PatientContactAddressTableCreator : IPatientAddressTableCreator
    {
        private readonly DbDatabaseConnection _databaseConnection;

        public PatientContactAddressTableCreator(DbDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_addresses (pk bigserial primary key, patient_fk bigint, foreign key (patient_fk) references patients(pk), use text, type text, text text, city text, district text, state text, postal_code text, country text, period_start timestamp, period_end timestamp)";
            await using var cmd = new NpgsqlCommand(sql, _databaseConnection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}