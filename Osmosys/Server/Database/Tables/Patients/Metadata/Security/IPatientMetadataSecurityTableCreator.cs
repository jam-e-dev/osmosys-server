using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Metadata.Security
{
    public interface IPatientMetadataSecurityTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}