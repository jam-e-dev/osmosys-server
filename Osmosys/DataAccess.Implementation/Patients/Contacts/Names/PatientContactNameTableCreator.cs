using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Contacts.Names;

namespace DataAccess.Implementation.Patients.Contacts.Names
{
    public class PatientContactNameTableCreator : IPatientContactNameTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly PatientContactNameTable _table;

        public PatientContactNameTableCreator(
            TableBuilderFactory builderFactory,
            PatientContactNameTable table)
        {
            _builderFactory = builderFactory;
            _table = table;
        }

        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.Use)
                .Add(_table.Text)
                .Add(_table.Family)
                .Add(_table.PeriodStart)
                .Add(_table.PeriodEnd)
                .CreateIfNotExistsAsync();
        }
    }
}