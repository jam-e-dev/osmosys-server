using System.Threading.Tasks;
using Common;
using Common.DataTypes;

namespace DataAccess.Patients.Contacts.Relationships
{
    public interface IPatientContactRelationshipRecordWriter
    {
        Task WriteAsync(CodeableConcept relationship);
    }
}