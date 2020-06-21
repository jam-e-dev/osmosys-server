using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Names
{
    public interface IPatientGivenNameTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}