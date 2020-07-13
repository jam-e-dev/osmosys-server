using System.Threading.Tasks;

namespace DataAccess.Patients.MaritalStatuses
{
    public interface IMaritalStatusCodingTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}