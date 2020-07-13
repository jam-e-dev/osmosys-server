using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Addresses;

namespace DataAccess.Implementation.Patients.Contacts.Addresses
{
    public class PatientContactAddressLineTableCreator : IPatientAddressLineTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly PatientContactAddressLineTable _table;

        public PatientContactAddressLineTableCreator(
            TableBuilderFactory builderFactory,
            PatientContactAddressLineTable table)
        {
            _builderFactory = builderFactory;
            _table = table;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.Line)
                .Add(_table.PatientContactAddressFk)
                .CreateIfNotExistsAsync();
        }
    }
}