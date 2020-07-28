using System.Threading.Tasks;
using Common.DataTypes;

namespace DataAccess.MaritalStatuses
{
    public interface IMaritalStatusRecordWriter
    {
        Task<long> WriteAsync(CodeableConcept status);
    }
}