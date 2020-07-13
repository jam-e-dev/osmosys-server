using System.Threading.Tasks;
using DataAccess.Patients.Contacts.Addresses;

namespace DataAccess.Implementation.Patients.Contacts.Addresses
{
    public class PatientContactAddressStorage : IPatientContactAddressStorage
    {
        private readonly IPatientContactAddressTableCreator _patientContactAddressTableCreator;
        private readonly IPatientContactAddressLineTableCreator _patientContactAddressLineTableCreator;

        public PatientContactAddressStorage(
            IPatientContactAddressTableCreator patientContactAddressTableCreator,
            IPatientContactAddressLineTableCreator patientContactAddressLineTableCreator)
        {
            _patientContactAddressTableCreator = patientContactAddressTableCreator;
            _patientContactAddressLineTableCreator = patientContactAddressLineTableCreator;
        }
        public async Task InitAsync()
        {
            await _patientContactAddressTableCreator.CreateIfNotExistsAsync();
            await _patientContactAddressLineTableCreator.CreateIfNotExistsAsync();
        }
    }
}