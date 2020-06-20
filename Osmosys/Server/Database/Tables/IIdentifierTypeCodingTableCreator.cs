using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public interface IIdentifierTypeCodingTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}