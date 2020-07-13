using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Contacts;

namespace DataAccess.Implementation.Patients.Contacts
{
    public class PatientContactTableCreator : IPatientContactTableCreator
    {
        private readonly PatientContactTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public PatientContactTableCreator(
            PatientContactTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientFk)
                .Add(_table.PatientContactNameFk)
                .Add(_table.PatientContactAddressFk)
                .Add(_table.Gender)
                .Add(_table.PeriodStart)
                .Add(_table.PeriodEnd)
                .CreateIfNotExistsAsync();
        }
    }
}