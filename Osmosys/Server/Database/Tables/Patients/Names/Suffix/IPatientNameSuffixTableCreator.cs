using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Names.Suffix
{
    public interface IPatientNameSuffixTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}