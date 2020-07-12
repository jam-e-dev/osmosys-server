using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Addresses;

namespace DataAccess.Implementation.Patients.Addresses
{
    public class PatientAddressTableCreator : IPatientAddressTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly PatientAddressTable _table;
        
        public PatientAddressTableCreator(
            TableBuilderFactory factory,
            PatientAddressTable table)
        {
            _builderFactory = factory;
            _table = table;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientFk)
                .Add(_table.Use)
                .Add(_table.Type)
                .Add(_table.Text)
                .Add(_table.City)
                .Add(_table.District)
                .Add(_table.State)
                .Add(_table.PostalCode)
                .Add(_table.Country)
                .Add(_table.PeriodStart)
                .Add(_table.PeriodEnd)
                .CreateIfNotExistsAsync();
        }
    }
}