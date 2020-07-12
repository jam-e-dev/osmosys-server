using System.Threading.Tasks;

namespace DataAccess.Patients.Identifiers
{
    public interface IPatientIdentifierTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}