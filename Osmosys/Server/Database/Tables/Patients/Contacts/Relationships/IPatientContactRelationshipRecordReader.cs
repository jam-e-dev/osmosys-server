using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Contacts.Relationships
{
    public interface IPatientContactRelationshipRecordReader
    {
        Task<long> CountAsync();
    }
}