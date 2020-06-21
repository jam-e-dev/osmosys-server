using System.Threading.Tasks;

namespace Server.Database.Tables.Prefix
{
    public interface IPatientNamePrefixTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}