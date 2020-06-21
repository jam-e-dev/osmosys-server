using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public interface IPatientNameTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}