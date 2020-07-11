using System.Threading.Tasks;
using DataAccess.Implementation.Connection;
using DataAccess.Patients.Addresses;
using Npgsql;

namespace DataAccess.Implementation.Patients.Contacts.Addresses
{
    public class PatientContactAddressLineTableCreator : IPatientAddressLineTableCreator
    {
        private readonly DbDatabaseConnection _databaseConnection;

        public PatientContactAddressLineTableCreator(DbDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_contact_address_lines (pk bigserial primary key, patient_contact_address_fk bigint, foreign key (patient_contact_address_fk) references patient_contact_addresses(pk), line text)";
            await using var cmd = new NpgsqlCommand(sql, _databaseConnection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}