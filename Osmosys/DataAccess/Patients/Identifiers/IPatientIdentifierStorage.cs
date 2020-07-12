using System.Threading.Tasks;

namespace DataAccess.Patients.Identifiers
{
    public interface IPatientIdentifierStorage
    {
        Task InitAsync();
    }
}