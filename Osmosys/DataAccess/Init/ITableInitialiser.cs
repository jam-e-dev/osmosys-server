using System.Threading.Tasks;

namespace DataAccess.Init
{
    public interface ITableInitialiser
    {
        Task InitAsync();
    }
}