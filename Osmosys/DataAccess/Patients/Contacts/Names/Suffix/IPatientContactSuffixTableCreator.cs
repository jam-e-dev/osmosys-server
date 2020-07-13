using System.Threading.Tasks;

namespace DataAccess.Patients.Contacts.Names.Suffix
{
    public interface IPatientContactSuffixTableCreator
    {
        Task CreateIfNotExistsAsync();
    }
}