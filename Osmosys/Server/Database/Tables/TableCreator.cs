using System.Threading.Tasks;
using Server.Database.Tables.IdentifierTypes;
using Server.Database.Tables.Patients;
using Server.Database.Tables.Patients.Addresses;
using Server.Database.Tables.Patients.Identifiers;
using Server.Database.Tables.Patients.Metadata;
using Server.Database.Tables.Patients.Metadata.Profiles;
using Server.Database.Tables.Patients.Metadata.Security;
using Server.Database.Tables.Patients.Metadata.Tags;
using Server.Database.Tables.Patients.Names;
using Server.Database.Tables.Patients.Names.Given;
using Server.Database.Tables.Patients.Names.Prefix;
using Server.Database.Tables.Patients.Names.Suffix;

namespace Server.Database.Tables
{
    public class TableCreator : ITableCreator
    {
        private readonly IIdentifierTypeCodingTableCreator _identifierTypeCodingTableCreator;
        private readonly IIdentifierTypeTableCreator _identifierTypeTableCreator;
        
        private readonly IPatientTableCreator _patientTableCreator;
        private readonly IPatientIdentifierTableCreator _patientIdentifierTableCreator;
        
        private readonly IPatientNameTableCreator _patientNameTableCreator;
        private readonly IPatientGivenNameTableCreator _patientGivenNameTableCreator;
        private readonly IPatientNamePrefixTableCreator _patientNamePrefixTableCreator;
        private readonly IPatientNameSuffixTableCreator _patientNameSuffixTableCreator;
        
        private readonly IPatientAddressTableCreator _patientAddressTableCreator;
        private readonly IPatientAddressLineTableCreator _patientAddressLineTableCreator;

        private readonly IPatientMetadataTableCreator _patientMetadataTableCreator;
        private readonly IPatientMetadataProfileTableCreator _patientMetadataProfileTableCreator;
        private readonly IPatientMetadataSecurityTableCreator _patientMetadataSecurityTableCreator;
        private readonly IPatientMetadataTagTableCreator _patientMetadataTagTableCreator;

        public TableCreator(
            IIdentifierTypeCodingTableCreator identifierTypeCodingTableCreator,
            IIdentifierTypeTableCreator identifierTypeTableCreator,
            IPatientTableCreator patientTableCreator,
            IPatientIdentifierTableCreator patientIdentifierTableCreator,
            IPatientNameTableCreator patientNameTableCreator,
            IPatientGivenNameTableCreator patientGivenNameTableCreator,
            IPatientNamePrefixTableCreator patientNamePrefixTableCreator,
            IPatientNameSuffixTableCreator patientNameSuffixTableCreator,
            IPatientAddressTableCreator patientAddressTableCreator,
            IPatientAddressLineTableCreator patientAddressLineTableCreator,
            IPatientMetadataTableCreator patientMetadataTableCreator,
            IPatientMetadataProfileTableCreator patientMetadataProfileTableCreator,
            IPatientMetadataSecurityTableCreator patientMetadataSecurityTableCreator,
            IPatientMetadataTagTableCreator patientMetadataTagTableCreator)
        {
            _identifierTypeCodingTableCreator = identifierTypeCodingTableCreator;
            _identifierTypeTableCreator = identifierTypeTableCreator;
            _patientTableCreator = patientTableCreator;
            _patientIdentifierTableCreator = patientIdentifierTableCreator;
            _patientNameTableCreator = patientNameTableCreator;
            _patientGivenNameTableCreator = patientGivenNameTableCreator;
            _patientNameSuffixTableCreator = patientNameSuffixTableCreator;
            _patientNamePrefixTableCreator = patientNamePrefixTableCreator;
            _patientAddressTableCreator = patientAddressTableCreator;
            _patientAddressLineTableCreator = patientAddressLineTableCreator;
            _patientMetadataTableCreator = patientMetadataTableCreator;
            _patientMetadataProfileTableCreator = patientMetadataProfileTableCreator;
            _patientMetadataSecurityTableCreator = patientMetadataSecurityTableCreator;
            _patientMetadataTagTableCreator = patientMetadataTagTableCreator;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _identifierTypeTableCreator.CreateIfNotExistsAsync();
            await _identifierTypeCodingTableCreator.CreateIfNotExistsAsync();
            
            await _patientTableCreator.CreateIfNotExistsAsync();
            await _patientIdentifierTableCreator.CreateIfNotExistsAsync();
            
            await _patientNameTableCreator.CreateIfNotExistsAsync();
            await _patientGivenNameTableCreator.CreateIfNotExistsAsync();
            await _patientNamePrefixTableCreator.CreateIfNotExistsAsync();
            await _patientNameSuffixTableCreator.CreateIfNotExistsAsync();
            
            await _patientAddressTableCreator.CreateIfNotExistsAsync();
            await _patientAddressLineTableCreator.CreateIfNotExistsAsync();

            await _patientMetadataTableCreator.CreateIfNotExistsAsync();
            await _patientMetadataProfileTableCreator.CreateIfNotExistsAsync();
            await _patientMetadataSecurityTableCreator.CreateIfNotExistsAsync();
            await _patientMetadataTagTableCreator.CreateIfNotExistsAsync();
        }
    }
}