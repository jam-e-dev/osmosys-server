using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Metadata
{
    public interface IPatientMetadataTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}