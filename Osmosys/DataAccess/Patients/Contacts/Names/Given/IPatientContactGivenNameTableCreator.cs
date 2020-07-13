using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts.Names.Given
{
    public interface IPatientContactGivenNameTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}