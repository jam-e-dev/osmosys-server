using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.MaritalStatuses;

namespace DataAccess.Implementation.MaritalStatuses
{
    public class MaritalStatusTableCreator : IMaritalStatusTableCreator
    {
        private readonly MaritalStatusTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public MaritalStatusTableCreator(
            MaritalStatusTable table,
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