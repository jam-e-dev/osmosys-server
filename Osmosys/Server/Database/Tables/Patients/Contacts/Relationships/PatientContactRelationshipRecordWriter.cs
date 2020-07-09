using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipRecordWriter : IPatientContactRelationshipRecordWriter
    {
        private readonly DbConnection _connection;

        public PatientContactRelationshipRecordWriter(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task WriteAsync(CodeableConcept relationship)
        {
            var pk = await WritePatientContactRelationshipAsync(relationship);
            
            foreach (var coding in relationship.Coding)
            {
                await WritePatientContactRelationshipCodingAsync(coding, pk);
            }
        }

        private async Task<long> WritePatientContactRelationshipAsync(CodeableConcept relationship)
        {
            const string sql = "insert into patient_contact_relationships (text text) values (@text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            cmd.Parameters.AddWithValue("text", relationship.Text);
            return (long) await cmd.ExecuteScalarAsync();
        }

        private async Task WritePatientContactRelationshipCodingAsync(Coding coding, long patientContactRelationshipPk)
        {
            const string sql = "insert into patient_contact_relationship_codings (patient_contact_relationship_fk bigint, foreign key patient_contact_relationship_fk references patient_contact_relationships(pk), system text, version text, code text, display text, user_selected boolean) values (@patientContactRelationshipFk, @system, @version, @code, @display, @userSelected)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            cmd.Parameters.AddWithValue("patientContactRelationshipFk", patientContactRelationshipPk);
            cmd.Parameters.AddWithValue("system", coding.System);
            cmd.Parameters.AddWithValue("version", coding.Version);
            cmd.Parameters.AddWithValue("code", coding.Code);
            cmd.Parameters.AddWithValue("display", coding.Display);
            cmd.Parameters.AddWithValue("userSelected", coding.UserSelected);
        }
    }
}