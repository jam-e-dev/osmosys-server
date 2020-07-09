using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Contacts.Names
{
    public interface IPatientContactNameTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}