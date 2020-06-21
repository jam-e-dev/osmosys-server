using System.Threading.Tasks;

namespace Server.Database.Tables.Suffix
{
    public interface IPatientNameSuffixTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}