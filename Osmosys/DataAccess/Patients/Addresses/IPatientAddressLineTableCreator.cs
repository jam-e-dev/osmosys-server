using System.Threading.Tasks;

namespace DataAccess.Patients.Addresses
{
    public interface IPatientAddressLineTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}