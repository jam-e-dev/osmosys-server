using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Names.Suffix
{
    public class PatientNameSuffixTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientNameFk => AddForeign("patient_name_fk", _patientNameTable.Pk);
        public DbColumn Suffix => AddColumn("suffix", DataTypes.Long);

        private readonly PatientNameTable _patientNameTable;

        public PatientNameSuffixTable(PatientNameTable patientNameTable) : base("patient_name_suffixes")
        {
            _patientNameTable = patientNameTable;
        }
    }
}