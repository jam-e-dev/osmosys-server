using System.Threading.Tasks;
using Common.DataTypes;
using DataAccess.MaritalStatuses;

namespace DataAccess.Implementation.MaritalStatuses
{
    public class MaritalStatusRecordWriter : IMaritalStatusRecordWriter
    {
        public Task<long> WriteAsync(CodeableConcept status)
        {
            throw new System.NotImplementedException();
        }
    }
}