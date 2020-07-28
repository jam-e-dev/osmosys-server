using System.Threading.Tasks;
using Common.DataTypes;
using DataAccess.MaritalStatuses;

namespace DataAccess.Implementation.MaritalStatuses
{
    public class MaritalStatusCodingRecordWriter : IMaritalStatusCodingRecordWriter
    {
        public Task<long> WriteAsync(Coding coding, long pkMaritalStatus)
        {
            throw new System.NotImplementedException();
        }
    }
}