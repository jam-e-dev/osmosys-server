using System.Threading.Tasks;
using DataAccess.Patients.Contacts.Names;
using DataAccess.Patients.Contacts.Names.Given;
using DataAccess.Patients.Contacts.Names.Prefix;
using DataAccess.Patients.Contacts.Names.Suffix;

namespace DataAccess.Implementation.Patients.Contacts.Names
{
    public class PatientContactNameStorage : IPatientContactNameStorage
    {
        private readonly IPatientContactNameTableCreator _patientContactNameTableCreator;
        private readonly IPatientContactGivenNameTableCreator _patientContactGivenNameTableCreator;
        private readonly IPatientContactPrefixTableCreator _patientContactPrefixTableCreator;
        private readonly IPatientContactSuffixTableCreator _patientContactSuffixTableCreator;

        public PatientContactNameStorage(
            IPatientContactNameTableCreator patientContactNameTableCreator,
            IPatientContactGivenNameTableCreator patientContactGivenNameTableCreator,
            IPatientContactPrefixTableCreator patientContactPrefixTableCreator,
            IPatientContactSuffixTableCreator patientContactSuffixTableCreator)
        {
            _patientContactNameTableCreator = patientContactNameTableCreator;
            _patientContactPrefixTableCreator = patientContactPrefixTableCreator;
            _patientContactGivenNameTableCreator = patientContactGivenNameTableCreator;
            _patientContactSuffixTableCreator = patientContactSuffixTableCreator;
        }
        
        public async Task InitAsync()
        {
            await _patientContactNameTableCreator.CreateIfNotExistsAsync();
            await _patientContactGivenNameTableCreator.CreateIfNotExistsAsync();
            await _patientContactPrefixTableCreator.CreateIfNotExistsAsync();
            await _patientContactSuffixTableCreator.CreateIfNotExistsAsync();
        }
    }
}