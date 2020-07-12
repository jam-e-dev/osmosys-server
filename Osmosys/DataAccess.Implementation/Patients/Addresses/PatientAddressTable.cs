using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Addresses
{
    public class PatientAddressTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientFk => AddForeign("patient_fk", _patientTable.Pk);
        public DbColumn Use => AddColumn("use", DataTypes.Text);
        public DbColumn Type => AddColumn("type", DataTypes.Text);
        public DbColumn Text => AddColumn("text", DataTypes.Text);
        public DbColumn City => AddColumn("city", DataTypes.Text);
        public DbColumn District => AddColumn("district", DataTypes.Text);
        public DbColumn State => AddColumn("state", DataTypes.Text);
        public DbColumn PostalCode => AddColumn("postal_code", DataTypes.Text);
        public DbColumn Country => AddColumn("country", DataTypes.Text);
        public DbColumn PeriodStart => AddColumn("period_start", DataTypes.Timestamp);
        public DbColumn PeriodEnd => AddColumn("period_end", DataTypes.Timestamp);

        private readonly PatientTable _patientTable;

        public PatientAddressTable(PatientTable patientTable) : base("patient_addresses")
        {
            _patientTable = patientTable;
        }
    }
}