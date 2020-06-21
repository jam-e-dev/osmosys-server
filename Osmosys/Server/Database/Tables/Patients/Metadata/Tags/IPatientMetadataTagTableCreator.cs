using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Metadata.Tags
{
    public interface IPatientMetadataTagTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}