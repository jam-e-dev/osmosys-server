using System.Threading.Tasks;

namespace DataAccess.Patients.Identifiers.Types
{
    public interface IIdentifierTypeCodingTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}