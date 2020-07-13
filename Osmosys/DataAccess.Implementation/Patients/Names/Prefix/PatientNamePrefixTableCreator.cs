using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Names.Prefix;

namespace DataAccess.Implementation.Patients.Names.Prefix
{
    public class PatientNamePrefixTableCreator : IPatientNamePrefixTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly PatientNamePrefixTable _table;

        public PatientNamePrefixTableCreator(
            TableBuilderFactory factory,
            PatientNamePrefixTable table)
        {
            _builderFactory = factory;
            _table = table;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientNameFk)
                .Add(_table.Prefix)
                .CreateIfNotExistsAsync();
        }
    }
}