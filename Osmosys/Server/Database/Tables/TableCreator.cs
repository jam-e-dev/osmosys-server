using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public class TableCreator : ITableCreator
    {
        private readonly IIdentifierTypeCodingTableCreator _identifierTypeCodingTableCreator;
        private readonly IIdentifierTypeTableCreator _identifierTypeTableCreator;
        
        public TableCreator(
            IIdentifierTypeCodingTableCreator identifierTypeCodingTableCreator,
            IIdentifierTypeTableCreator identifierTypeTableCreator)
        {
            _identifierTypeCodingTableCreator = identifierTypeCodingTableCreator;
            _identifierTypeTableCreator = identifierTypeTableCreator;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            
            await _identifierTypeTableCreator.CreateIfNotExistsAsync();
            await _identifierTypeCodingTableCreator.CreateIfNotExistsAsync();
        }
    }
}