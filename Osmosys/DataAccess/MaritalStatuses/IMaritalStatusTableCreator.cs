using System.Threading.Tasks;

namespace DataAccess.MaritalStatuses
{
    public interface IMaritalStatusTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}