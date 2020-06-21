using System.Threading.Tasks;

namespace Server.Database.Tables.Patients
{
    public interface IPatientTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}