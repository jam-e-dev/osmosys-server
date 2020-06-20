using System.Threading.Tasks;

namespace Server.Database.Tables
{
    public class TableCreator : ITableCreator
    {
        private readonly IIdentifierTypeCodingTableCreator _identifierTypeCodingTableCreator;
        private readonly IIdentifierTypeTableCreator _identifierTypeTableCreator;
        private readonly IPatientTableCreator _patientTableCreator;
        
        public TableCreator(
            IIdentifierTypeCodingTableCreator identifierTypeCodingTableCreator,
            IIdentifierTypeTableCreator identifierTypeTableCreator,
            IPatientTableCreator patientTableCreator)
        {
            _identifierTypeCodingTableCreator = identifierTypeCodingTableCreator;
            _identifierTypeTableCreator = identifierTypeTableCreator;
            _patientTableCreator = patientTableCreator;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _identifierTypeTableCreator.CreateIfNotExistsAsync();
            await _identifierTypeCodingTableCreator.CreateIfNotExistsAsync();
            await _patientTableCreator.CreateIfNotExistsAsync();
        }
    }
}