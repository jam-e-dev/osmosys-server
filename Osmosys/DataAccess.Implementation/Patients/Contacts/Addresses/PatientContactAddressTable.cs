using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Addresses
{
    public class PatientContactAddressTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public DbColumn Line => AddColumn("line", DataTypes.Text);

        public PatientContactAddressTable() : base("patient_contact_addresses")
        {
        }
    }
}