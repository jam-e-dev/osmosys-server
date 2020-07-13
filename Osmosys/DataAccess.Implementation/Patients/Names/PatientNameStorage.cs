using System.Threading.Tasks;
using DataAccess.Patients.Names;
using DataAccess.Patients.Names.Given;
using DataAccess.Patients.Names.Prefix;
using DataAccess.Patients.Names.Suffix;

namespace DataAccess.Implementation.Patients.Names
{
    public class PatientNameStorage : IPatientNameStorage
    {
        private readonly IPatientNameTableCreator _patientNameTableCreator;
        private readonly IPatientGivenNameTableCreator _patientGivenNameTableCreator;
        private readonly IPatientNamePrefixTableCreator _patientNamePrefixTableCreator;
        private readonly IPatientNameSuffixTableCreator _patientNameSuffixTableCreator;

        public PatientNameStorage(
            IPatientNameTableCreator patientNameTableCreator,
            IPatientGivenNameTableCreator patientGivenNameTableCreator,
            IPatientNamePrefixTableCreator patientNamePrefixTableCreator,
            IPatientNameSuffixTableCreator patientNameSuffixTableCreator)
        {
            _patientNameTableCreator = patientNameTableCreator;
            _patientGivenNameTableCreator = patientGivenNameTableCreator;
            _patientNamePrefixTableCreator = patientNamePrefixTableCreator;
            _patientNameSuffixTableCreator = patientNameSuffixTableCreator;
        }
        
        public async Task InitAsync()
        {
            await _patientNameTableCreator.CreateIfNotExistsAsync();
            await _patientGivenNameTableCreator.CreateIfNotExistsAsync();
            await _patientNamePrefixTableCreator.CreateIfNotExistsAsync();
            await _patientNameSuffixTableCreator.CreateIfNotExistsAsync();
        }
    }
}