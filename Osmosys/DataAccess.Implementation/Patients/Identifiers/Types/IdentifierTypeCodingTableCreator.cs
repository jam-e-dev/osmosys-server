using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Identifiers.Types;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeCodingTableCreator : IIdentifierTypeCodingTableCreator
    {
        private readonly TableBuilderFactory _builderFactory;
        private readonly IdentifierTypeCodingTable _table;
        
        public IdentifierTypeCodingTableCreator(
            TableBuilderFactory factory,
            IdentifierTypeCodingTable table)
        {
            _builderFactory = factory;
            _table = table;
        }

        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.IdentifierTypeFk)
                .Add(_table.System)
                .Add(_table.Version)
                .Add(_table.Code)
                .Add(_table.Display)
                .Add(_table.UserSelected)
                .CreateIfNotExistsAsync();
        }
    }
}