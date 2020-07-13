using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Addresses;

namespace DataAccess.Implementation.Patients.Contacts.Addresses
{
    public class PatientContactAddressTableCreator : IPatientAddressTableCreator
    {
        private readonly PatientContactAddressTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public PatientContactAddressTableCreator(
            PatientContactAddressTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.Line)
                .CreateIfNotExistsAsync();
        }
    }
}