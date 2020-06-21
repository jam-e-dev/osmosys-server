using System.Threading.Tasks;

namespace Server.Database.Tables.IdentifierTypes
{
    public interface IIdentifierTypeCodingTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}