using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Names
{
    public class PatientNameTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientFk => AddForeign("patient_fk", _patientTable.Pk);
        public DbColumn Use => AddColumn("use", DataTypes.Text);
        public DbColumn Text => AddColumn("text", DataTypes.Text);
        public DbColumn Family => AddColumn("family", DataTypes.Text);
        public DbColumn PeriodStart => AddColumn("period_start", DataTypes.Timestamp);
        public DbColumn PeriodEnd => AddColumn("period_end", DataTypes.Text);

        private readonly PatientTable _patientTable;

        public PatientNameTable(PatientTable patientTable) : base("patient_names")
        {
            _patientTable = patientTable;
        }
    }
}