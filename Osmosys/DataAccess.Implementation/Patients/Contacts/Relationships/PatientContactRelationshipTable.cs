using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public DbColumn Text => AddColumn("text", DataTypes.Text);
        
        public PatientContactRelationshipTable() : base("patient_contact_relationships")
        {
        }
    }
}