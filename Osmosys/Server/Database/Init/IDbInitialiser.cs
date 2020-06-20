using System.Threading.Tasks;

namespace Server.Database.Init
{
    public interface IDbInitialiser
    {
        Task InitAsync();
    }
}