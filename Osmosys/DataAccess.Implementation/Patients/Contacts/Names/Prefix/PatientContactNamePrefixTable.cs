using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Names.Prefix
{
    public class PatientContactNamePrefixTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientNameFk => AddForeign("patient_contact_name_fk", _patientContactNameTable.Pk);
        public DbColumn Prefix => AddColumn("prefix", DataTypes.Long);

        private readonly PatientContactNameTable _patientContactNameTable;

        public PatientContactNamePrefixTable(PatientContactNameTable patientContactNameTable) : base("patient_contact_name_prefixes")
        {
            _patientContactNameTable = patientContactNameTable;
        }
    }
}