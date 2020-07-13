using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Relationships
{
    public class PatientContactRelationshipCodingTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientContactRelationshipFk => AddForeign("patient_contact_relationship_fk", _patientContactRelationshipTable.Pk);
        public DbColumn System => AddColumn("system", DataTypes.Text);
        public DbColumn Version => AddColumn("version", DataTypes.Text);
        public DbColumn Code => AddColumn("code", DataTypes.Text);
        public DbColumn Display => AddColumn("display", DataTypes.Text);
        public DbColumn UserSelected => AddColumn("user_selected", DataTypes.Bool);

        private readonly PatientContactRelationshipTable _patientContactRelationshipTable;
        
        public PatientContactRelationshipCodingTable(PatientContactRelationshipTable patientContactRelationshipTable) : base("patient_contact_relationship_codings")
        {
            _patientContactRelationshipTable = patientContactRelationshipTable;
        }
    }
}