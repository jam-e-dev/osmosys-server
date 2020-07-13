using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts.Telecoms
{
    public interface IPatientContactTelecomTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}