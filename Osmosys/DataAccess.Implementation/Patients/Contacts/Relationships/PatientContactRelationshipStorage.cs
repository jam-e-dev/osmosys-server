using System.Threading.Tasks;
using DataAccess.Patients.Contacts.Relationships;

namespace DataAccess.Implementation.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipStorage : IPatientContactRelationshipStorage
    {
        private readonly IPatientContactRelationshipTableCreator _patientContactRelationshipTableCreator;
        private readonly IPatientContactRelationshipCodingTableCreator _patientContactRelationshipCodingTableCreator;

        public PatientContactRelationshipStorage(
            IPatientContactRelationshipTableCreator patientContactRelationshipTableCreator,
            IPatientContactRelationshipCodingTableCreator patientContactRelationshipCodingTableCreator)
        {
            _patientContactRelationshipTableCreator = patientContactRelationshipTableCreator;
            _patientContactRelationshipCodingTableCreator = patientContactRelationshipCodingTableCreator;
        }

        public async Task InitAsync()
        {
            await _patientContactRelationshipTableCreator.CreateIfNotExistsAsync();
            await _patientContactRelationshipCodingTableCreator.CreateIfNotExistsAsync();
        }
    }
}