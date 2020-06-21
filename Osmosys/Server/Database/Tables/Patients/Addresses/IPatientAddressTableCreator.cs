using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Addresses
{
    public interface IPatientAddressTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}