using System.Threading.Tasks;
using DataAccess.Patients.Identifiers;
using DataAccess.Patients.Identifiers.Types;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public class PatientIdentifierStorage : IPatientIdentifierStorage
    {
        private readonly IIdentifierTypeStorage _identifierTypeStorage;
        private readonly IPatientIdentifierTableCreator _patientIdentifierTableCreator;

        public PatientIdentifierStorage(
            IIdentifierTypeStorage identifierTypeStorage,
            IPatientIdentifierTableCreator patientIdentifierTableCreator)
        {
            _identifierTypeStorage = identifierTypeStorage;
            _patientIdentifierTableCreator = patientIdentifierTableCreator;
        }
        
        public async Task InitAsync()
        {
            await _identifierTypeStorage.InitAsync();
            await _patientIdentifierTableCreator.CreateIfNotExistsAsync();
        }
    }
}