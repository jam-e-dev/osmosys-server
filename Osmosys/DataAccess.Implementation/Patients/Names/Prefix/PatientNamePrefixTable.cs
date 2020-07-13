using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Names.Prefix
{
    public class PatientNamePrefixTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientNameFk => AddForeign("patient_name_fk", _patientNameTable.Pk);
        public DbColumn Prefix => AddColumn("prefix", DataTypes.Long);

        private readonly PatientNameTable _patientNameTable;

        public PatientNamePrefixTable(PatientNameTable patientNameTable) : base("patient_name_prefixes")
        {
            _patientNameTable = patientNameTable;
        }
    }
}