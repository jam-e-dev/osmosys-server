using System.Threading.Tasks;

namespace Server.Database.Tables.Patients.Contacts.Names.Given
{
    public interface IPatientContactGivenNameTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}