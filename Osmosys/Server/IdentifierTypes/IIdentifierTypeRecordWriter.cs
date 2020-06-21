using System.Threading.Tasks;

namespace Server.IdentifierTypes
{
    public interface IIdentifierTypeRecordWriter
    {
        Task WriteAsync(CodeableConcept type);
    }
}