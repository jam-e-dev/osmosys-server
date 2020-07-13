using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Contacts.Relationships;

namespace DataAccess.Implementation.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipTableCreator : IPatientContactRelationshipTableCreator
    {
        private readonly PatientContactRelationshipTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public PatientContactRelationshipTableCreator(
            PatientContactRelationshipTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.Text)
                .CreateIfNotExistsAsync();
        }
    }
}