using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Names.Suffix;

namespace DataAccess.Implementation.Patients.Names.Suffix
{
    public class PatientNameSuffixTableCreator : IPatientNameSuffixTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly PatientNameSuffixTable _table;

        public PatientNameSuffixTableCreator(
            TableBuilderFactory factory,
            PatientNameSuffixTable table)
        {
            _builderFactory = factory;
            _table = table;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientNameFk)
                .Add(_table.Suffix)
                .CreateIfNotExistsAsync();
        }
    }
}