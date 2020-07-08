using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Telecoms
{
    public interface IPatientTelecomTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}