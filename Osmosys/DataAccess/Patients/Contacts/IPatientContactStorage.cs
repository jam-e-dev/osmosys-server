using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts
{
    public interface IPatientContactStorage
    {
        Task InitAsync();
    }
}