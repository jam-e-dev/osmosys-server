using System.Threading.Tasks;

namespace Server.Database.Init
{
    public interface IDbCreator
    {
        Task CreateAsync();
    }
}