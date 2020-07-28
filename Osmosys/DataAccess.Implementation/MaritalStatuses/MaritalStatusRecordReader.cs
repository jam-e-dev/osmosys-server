using System.Threading.Tasks;
using DataAccess.MaritalStatuses;

namespace DataAccess.Implementation.MaritalStatuses
{
    public class MaritalStatusRecordReader : IMaritalStatusRecordReader
    {
        public Task<long> CountAsync { get; }
    }
}