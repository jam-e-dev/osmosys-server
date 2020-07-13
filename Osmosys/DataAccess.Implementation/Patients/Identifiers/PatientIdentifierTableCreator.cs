using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Identifiers;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public class PatientIdentifierTableCreator : IPatientIdentifierTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly PatientIdentifierTable _table;

        public PatientIdentifierTableCreator(
            TableBuilderFactory factory,
            PatientIdentifierTable table)
        {
            _builderFactory = factory;
            _table = table;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientFk)
                .Add(_table.IdentiferTypeFk)
                .Add(_table.Use)
                .Add(_table.System)
                .Add(_table.Value)
                .Add(_table.PeriodStart)
                .Add(_table.PeriodEnd)
                .CreateIfNotExistsAsync();
        }
    }
}