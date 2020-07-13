using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Contacts.Names.Suffix;

namespace DataAccess.Implementation.Patients.Contacts.Names.Suffix
{
    public class PatientContactNameSuffixTableCreator : IPatientContactSuffixTableCreator
    {
        private readonly PatientContactNameSuffixTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public PatientContactNameSuffixTableCreator(
            PatientContactNameSuffixTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
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