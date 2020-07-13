using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Names
{
    public class PatientContactNameTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public DbColumn Use => AddColumn("use", DataTypes.Text);
        public DbColumn Text => AddColumn("text", DataTypes.Text);
        public DbColumn Family => AddColumn("family", DataTypes.Text);
        public DbColumn PeriodStart => AddColumn("period_start", DataTypes.Timestamp);
        public DbColumn PeriodEnd => AddColumn("period_end", DataTypes.Text);
        

        public PatientContactNameTable() : base("patient_contact_names")
        {
        }
    }
}