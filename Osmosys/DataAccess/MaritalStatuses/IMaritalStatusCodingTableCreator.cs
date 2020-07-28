using System.Threading.Tasks;

namespace DataAccess.MaritalStatuses
{
    public interface IMaritalStatusCodingTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}