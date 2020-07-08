using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipTableCreator : IPatientContactRelationshipTableCreator
    {
        private readonly DbConnection _connection;

        public PatientContactRelationshipTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_contact_relationships (pk bigserial primary key, text text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}