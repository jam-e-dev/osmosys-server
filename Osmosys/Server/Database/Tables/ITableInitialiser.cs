using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public interface ITableInitialiser
    {
        Task InitAsync();
    }
}