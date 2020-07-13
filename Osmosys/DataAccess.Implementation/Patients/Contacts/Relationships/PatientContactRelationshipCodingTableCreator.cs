using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Contacts.Relationships;

namespace DataAccess.Implementation.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipCodingTableCreator : IPatientContactRelationshipCodingTableCreator
    {
        private readonly PatientContactRelationshipCodingTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public PatientContactRelationshipCodingTableCreator(
            PatientContactRelationshipCodingTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientContactRelationshipFk)
                .Add(_table.System)
                .Add(_table.Version)
                .Add(_table.Code)
                .Add(_table.Display)
                .Add(_table.UserSelected)
                .CreateIfNotExistsAsync();
        }
    }
}