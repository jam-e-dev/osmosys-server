using System.Threading.Tasks;

namespace DataAccess.Patients.Identifiers.Types
{
    public interface IIdentifierTypeRecordReader
    {
        Task<long> CountAsync();
    }
}