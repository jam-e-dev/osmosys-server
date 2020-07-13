using System.Threading.Tasks;
using DataAccess.Implementation.Connection;
using DataAccess.Patients.Contacts.Names.Prefix;
using Npgsql;

namespace DataAccess.Implementation.Patients.Contacts.Names.Prefix
{
    public class PatientContactNamePrefixTableCreator : IPatientContactPrefixTableCreator
    {
        private readonly DbDatabaseConnection _databaseConnection;

        public PatientContactNamePrefixTableCreator(DbDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_contact_name_suffixes (pk bigserial primary key, patient_contact_name_fk bigint, foreign key patient_contact_name_fk references patient_contact_names(pk), name suffix)";
            await using var cmd = new NpgsqlCommand(sql, _databaseConnection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}