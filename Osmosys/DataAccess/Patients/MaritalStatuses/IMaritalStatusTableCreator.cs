using System.Threading.Tasks;

namespace DataAccess.Patients.MaritalStatuses
{
    public interface IMaritalStatusTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}