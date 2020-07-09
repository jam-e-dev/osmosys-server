using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipRecordReader :  IPatientContactRelationshipRecordReader
    {
        private readonly DbConnection _connection;

        public PatientContactRelationshipRecordReader(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task<long> CountAsync()
        {
            const string sql = "select count(*) from patient_contact_relationships";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            return (long) await cmd.ExecuteScalarAsync();
        }
    }
}