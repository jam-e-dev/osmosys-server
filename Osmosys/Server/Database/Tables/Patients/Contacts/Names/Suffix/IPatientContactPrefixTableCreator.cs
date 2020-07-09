using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Contacts.Names.Suffix
{
    public interface IPatientContactPrefixTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}