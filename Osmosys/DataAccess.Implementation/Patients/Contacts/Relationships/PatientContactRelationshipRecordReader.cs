using System.Threading.Tasks;
using DataAccess.Implementation.Connection;
using DataAccess.Patients.Contacts.Relationships;
using Npgsql;

namespace DataAccess.Implementation.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipRecordReader :  IPatientContactRelationshipRecordReader
    {
        private readonly DbDatabaseConnection _databaseConnection;

        public PatientContactRelationshipRecordReader(DbDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        
        public async Task<long> CountAsync()
        {
            const string sql = "select count(*) from patient_contact_relationships";
            await using var cmd = new NpgsqlCommand(sql, _databaseConnection.Current);
            return (long) await cmd.ExecuteScalarAsync();
        }
    }
}