using System.Threading.Tasks;

namespace DataAccess.Patients.Addresses
{
    public interface IPatientAddressTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}