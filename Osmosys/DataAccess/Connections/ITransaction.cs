using System.Threading.Tasks;

namespace DataAccess.Connections
{
    public interface ITransaction
    {
        Task BeginAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}