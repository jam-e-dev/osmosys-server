using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Contacts.Names
{
    public class PatientContactNameTableCreator : IPatientContactNameTableCreator
    {
        private readonly DbConnection _connection;

        public PatientContactNameTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_contact_names (pk bigserial primary key, patient_contact_fk bigint, foreign key patient_contact_fk references patient_contacts(pk), use text, text text, family text, period_start timestamp, period_end timestamp)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}