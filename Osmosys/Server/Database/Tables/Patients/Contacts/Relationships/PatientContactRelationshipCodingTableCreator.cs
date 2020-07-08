using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipCodingTableCreator : IPatientContactRelationshipCodingTableCreator
    {
        private readonly DbConnection _connection;

        public PatientContactRelationshipCodingTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_contact_relationship_codings (pk bigserial primary key, patient_contact_relationship_fk bigint, foreign key patient_contact_relationship_fk references patient_contact_relationships(pk), system text, version text, code text, display text, user_selected boolean)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}