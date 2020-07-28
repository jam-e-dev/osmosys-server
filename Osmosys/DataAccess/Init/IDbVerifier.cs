using System.Threading.Tasks;

namespace DataAccess.Init
{
    public interface IDbVerifier
    {
        Task<bool> VerifyAsync();
    }
}