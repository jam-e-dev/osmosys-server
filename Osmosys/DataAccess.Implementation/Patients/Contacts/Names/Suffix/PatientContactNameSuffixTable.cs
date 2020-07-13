using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Names.Suffix
{
    public class PatientContactNameSuffixTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientNameFk => AddForeign("patient_contact_name_fk", _patientContactNameTable.Pk);
        public DbColumn Suffix => AddColumn("suffix", DataTypes.Long);

        private readonly PatientContactNameTable _patientContactNameTable;

        public PatientContactNameSuffixTable(PatientContactNameTable patientContactNameTable) : base("patient_contact_name_suffixes")
        {
            _patientContactNameTable = patientContactNameTable;
        }
    }
}