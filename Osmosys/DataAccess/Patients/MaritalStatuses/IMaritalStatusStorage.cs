using System.Threading.Tasks;

namespace DataAccess.Patients.MaritalStatuses
{
    public interface IMaritalStatusStorage
    {
        Task InitAsync();
    }
}