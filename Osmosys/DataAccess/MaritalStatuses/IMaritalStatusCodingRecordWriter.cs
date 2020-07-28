using System.Threading.Tasks;
using Common.DataTypes;

namespace DataAccess.MaritalStatuses
{
    public interface IMaritalStatusCodingRecordWriter
    {
        Task<long> WriteAsync(Coding coding, long pkMaritalStatus);
    }
}