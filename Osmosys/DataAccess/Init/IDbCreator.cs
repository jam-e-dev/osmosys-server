using System.Threading.Tasks;

namespace DataAccess.Init
{
    public interface IDbCreator
    {
        Task CreateAsync();
    }
}