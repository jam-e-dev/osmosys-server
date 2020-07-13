using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.MaritalStatuses;

namespace DataAccess.Implementation.Patients.MaritalStatuses
{
    public class MaritalStatusCodingTableCreator : IMaritalStatusCodingTableCreator
    {
        private readonly MaritalStatusCodingTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public MaritalStatusCodingTableCreator(
            MaritalStatusCodingTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
        }

        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.MaritalStatusFk)
                .Add(_table.System)
                .Add(_table.Version)
                .Add(_table.Code)
                .Add(_table.Display)
                .Add(_table.UserSelected)
                .CreateIfNotExistsAsync();
        }
    }
}