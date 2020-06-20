using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public interface IPatientIdentifierTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}