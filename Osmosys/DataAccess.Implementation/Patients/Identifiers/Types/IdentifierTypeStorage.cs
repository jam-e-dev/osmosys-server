using System.Threading.Tasks;
using DataAccess.Patients.Identifiers.Types;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeStorage : IIdentifierTypeStorage
    {
        private readonly IIdentifierTypeTableCreator _identifierTypeTableCreator;
        private readonly IIdentifierTypeCodingTableCreator _identifierTypeCodingTableCreator;
        private readonly IIdentifierTypeRecordReader _identifierTypeRecordReader;
        private readonly IIdentifierTypeRecordWriter _identifierTypeRecordWriter;

        public IdentifierTypeStorage(
            IIdentifierTypeTableCreator identifierTypeTableCreator,
            IIdentifierTypeCodingTableCreator identifierTypeCodingTableCreator,
            IIdentifierTypeRecordReader identifierTypeRecordReader,
            IIdentifierTypeRecordWriter identifierTypeRecordWriter)
        {
            _identifierTypeTableCreator = identifierTypeTableCreator;
            _identifierTypeCodingTableCreator = identifierTypeCodingTableCreator;
            _identifierTypeRecordReader = identifierTypeRecordReader;
            _identifierTypeRecordWriter = identifierTypeRecordWriter;
        }
        
        public async Task InitAsync()
        {
            await InitTablesAsync();
            await InitDataAsync();
        }

        private async Task InitTablesAsync()
        {
            await _identifierTypeTableCreator.CreateIfNotExistsAsync();
            await _identifierTypeCodingTableCreator.CreateIfNotExistsAsync();
        }

        private async Task InitDataAsync()
        {
            var identifierTypeCount = await _identifierTypeRecordReader.CountAsync();
            var noIdentifierTypesFound = identifierTypeCount < 1;
            
            if (noIdentifierTypesFound)
            {
                var defaultTypes = IdentifierTypeDefaults.Defaults;

                foreach (var type in defaultTypes)
                {
                    await _identifierTypeRecordWriter.WriteAsync(type);
                }
            }
        }
    }
}