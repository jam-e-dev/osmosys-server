using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Identifiers
{
    public interface IPatientIdentifierTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}