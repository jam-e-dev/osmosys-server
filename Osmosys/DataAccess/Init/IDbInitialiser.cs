using System.Threading.Tasks;

namespace DataAccess.Init
{
    public interface IDbInitialiser
    {
        Task InitAsync();
    }
}