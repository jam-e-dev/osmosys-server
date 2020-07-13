using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Identifiers.Types;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeTableCreator : IIdentifierTypeTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly IdentifierTypeTable _table;

        public IdentifierTypeTableCreator(
            TableBuilderFactory factory,
            IdentifierTypeTable table)
        {
            _builderFactory = factory;
            _table = table;
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