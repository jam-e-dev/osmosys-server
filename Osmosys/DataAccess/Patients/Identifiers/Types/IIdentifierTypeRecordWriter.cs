using System.Threading.Tasks;
using Common.DataTypes;

namespace DataAccess.Patients.Identifiers.Types
{
    public interface IIdentifierTypeRecordWriter
    {
        Task WriteAsync(CodeableConcept type);
    }
}