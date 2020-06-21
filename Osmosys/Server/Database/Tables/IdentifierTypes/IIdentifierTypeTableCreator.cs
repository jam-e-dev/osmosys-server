using System.Threading.Tasks;

namespace Server.Database.Tables.IdentifierTypes
{
    public interface IIdentifierTypeTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}