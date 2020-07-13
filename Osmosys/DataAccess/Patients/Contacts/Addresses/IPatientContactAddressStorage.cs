using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts.Addresses
{
    public interface IPatientContactAddressStorage
    {
        Task InitAsync();
    }
}