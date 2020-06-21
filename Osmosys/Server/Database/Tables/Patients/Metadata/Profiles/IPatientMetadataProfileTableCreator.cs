using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Metadata.Profiles
{
    public interface IPatientMetadataProfileTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}