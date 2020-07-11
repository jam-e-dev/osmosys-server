using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts.Addresses
{
    public interface IPatientContactAddressLineTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}