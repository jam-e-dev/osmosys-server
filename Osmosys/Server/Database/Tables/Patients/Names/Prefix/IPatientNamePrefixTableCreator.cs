using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Names.Prefix
{
    public interface IPatientNamePrefixTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}