using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Addresses
{
    public class PatientAddressLineTableCreator : IPatientAddressLineTableCreator
    {
        private readonly DbConnection _connection;

        public PatientAddressLineTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_address_lines (pk bigserial primary key, patient_address_fk bigint, foreign key (patient_address_fk) references patient_addresses(pk), line text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}