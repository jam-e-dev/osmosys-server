using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Contacts.Names.Given
{
    public class PatientContactGivenNameTableCreator : IPatientContactGivenNameTableCreator
    {
        private readonly DbConnection _connection;

        public PatientContactGivenNameTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_contact_given_names (pk bigserial primary key, patient_contact_name_fk bigint, foreign key patient_contact_name_fk references patient_contact_names(pk), name text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}