using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts.Relationships
{
    public interface IPatientContactRelationshipStorage
    {
        Task InitAsync();
    }
}