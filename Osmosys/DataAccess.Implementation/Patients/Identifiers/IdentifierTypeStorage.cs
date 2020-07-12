using System.Threading.Tasks;
using DataAccess.Patients.Identifiers;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public class IdentifierTypeStorage : IIdentifierTypeStorage
    {
        private readonly IIdentifierTypeTableCreator _identifierTypeTableCreator;
        private readonly IIdentifierTypeCodingTableCreator _identifierTypeCodingTableCreator;

        public IdentifierTypeStorage(
            IIdentifierTypeTableCreator identifierTypeTableCreator,
            IIdentifierTypeCodingTableCreator identifierTypeCodingTableCreator)
        {
            _identifierTypeTableCreator = identifierTypeTableCreator;
            _identifierTypeCodingTableCreator = identifierTypeCodingTableCreator;
        }
        
        public async Task InitAsync()
        {
            await _identifierTypeTableCreator.CreateIfNotExistsAsync();
            await _identifierTypeCodingTableCreator.CreateIfNotExistsAsync();
        }
    }
}