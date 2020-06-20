using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public interface IPatientTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}