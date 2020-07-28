using System.Threading.Tasks;

namespace DataAccess.MaritalStatuses
{
    public interface IMaritalStatusRecordReader
    {
        Task<long> CountAsync { get; }
    }
}