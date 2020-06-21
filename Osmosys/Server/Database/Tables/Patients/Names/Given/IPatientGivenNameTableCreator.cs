using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Names.Given
{
    public interface IPatientGivenNameTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}