using System.Threading.Tasks;

namespace Server.IdentifierTypes
{
    public interface IIdentifierTypeRecordReader
    {
        Task<long> CountAsync();
    }
}