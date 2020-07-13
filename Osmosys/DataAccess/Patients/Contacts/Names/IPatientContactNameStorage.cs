using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts.Names
{
    public interface IPatientContactNameStorage
    {
        Task InitAsync();
    }
}