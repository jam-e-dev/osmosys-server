using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public interface IIdentifierTypeTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}