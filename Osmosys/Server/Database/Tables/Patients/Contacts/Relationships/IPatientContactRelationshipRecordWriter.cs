using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Contacts.Relationships
{
    public interface IPatientContactRelationshipRecordWriter
    {
        Task WriteAsync(CodeableConcept relationship);
    }
}