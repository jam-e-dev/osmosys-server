using System.Threading.Tasks;
using DataAccess.Patients.Contacts;
using DataAccess.Patients.Contacts.Addresses;
using DataAccess.Patients.Contacts.Names;
using DataAccess.Patients.Contacts.Relationships;

namespace DataAccess.Implementation.Patients.Contacts
{
    public class PatientContactStorage : IPatientContactStorage
    {
        private readonly IPatientContactNameStorage _patientContactNameStorage;
        private readonly IPatientContactAddressStorage _patientContactAddressStorage;
        private readonly IPatientContactTableCreator _patientContactTableCreator;
        private readonly IPatientContactRelationshipStorage _patientContactRelationshipStorage;

        public PatientContactStorage(
            IPatientContactNameStorage patientContactNameStorage,
            IPatientContactAddressStorage patientContactAddressStorage,
            IPatientContactTableCreator patientContactTableCreator,
            IPatientContactRelationshipStorage patientContactRelationshipStorage)
        {
            _patientContactNameStorage = patientContactNameStorage;
            _patientContactAddressStorage = patientContactAddressStorage;
            _patientContactTableCreator = patientContactTableCreator;
            _patientContactRelationshipStorage = patientContactRelationshipStorage;
        }
        
        public async Task InitAsync()
        {
            await _patientContactNameStorage.InitAsync();
            await _patientContactAddressStorage.InitAsync();
            await _patientContactTableCreator.CreateIfNotExistsAsync();
            await _patientContactRelationshipStorage.InitAsync();
        }
    }
}