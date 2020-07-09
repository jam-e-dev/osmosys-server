using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Contacts.Names.Prefix
{
    public class PatientContactSuffixTableCreator : IPatientContactSuffixTableCreator
    {
        private readonly DbConnection _connection;

        public PatientContactSuffixTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_contact_name_prefixes (pk bigserial primary key, patient_contact_name_fk bigint, foreign key patient_contact_name_fk references patient_contact_names(pk), name prefix)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}