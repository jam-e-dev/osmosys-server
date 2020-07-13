using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts
{
    public interface IPatientContactTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}