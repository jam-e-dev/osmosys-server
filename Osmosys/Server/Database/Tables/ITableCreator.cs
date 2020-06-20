using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public interface ITableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}