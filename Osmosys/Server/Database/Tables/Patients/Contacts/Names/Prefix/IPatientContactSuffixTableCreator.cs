using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Contacts.Names.Prefix
{
    public interface IPatientContactSuffixTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}