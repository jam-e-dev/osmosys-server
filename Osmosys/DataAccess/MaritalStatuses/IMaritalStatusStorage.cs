using System.Threading.Tasks;

namespace DataAccess.MaritalStatuses
{
    public interface IMaritalStatusStorage
    {
        Task InitAsync();
    }
}