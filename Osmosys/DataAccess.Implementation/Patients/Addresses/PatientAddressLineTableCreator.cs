using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Addresses;

namespace DataAccess.Implementation.Patients.Addresses
{
    public class PatientAddressLineTableCreator : IPatientAddressLineTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly PatientAddressLineTable _addressLineTable;

        public PatientAddressLineTableCreator(
            TableBuilderFactory factory,
            PatientAddressLineTable addressLineTable)
        {
            _builderFactory = factory;
            _addressLineTable = addressLineTable;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_addressLineTable.TblName)
                .Add(_addressLineTable.Pk)
                .Add(_addressLineTable.PatientAddressFk)
                .Add(_addressLineTable.Line)
                .CreateIfNotExistsAsync();
        }
    }
}