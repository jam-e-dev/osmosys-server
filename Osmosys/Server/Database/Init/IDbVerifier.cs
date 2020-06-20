using System.Threading.Tasks;

namespace Server.Database.Init
{
    public interface IDbVerifier
    {
        Task<bool> VerifyAsync();
    }
}