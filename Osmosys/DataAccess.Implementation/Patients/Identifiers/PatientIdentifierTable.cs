using DataAccess.Implementation.Patients.Identifiers.Types;
using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public class PatientIdentifierTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientFk => AddForeign("patient_fk", _patientTable.Pk);
        public ForeignKey IdentiferTypeFk => AddForeign("identifier_type_fk", _identifierTypeTable.Pk);
        public DbColumn Use => AddColumn("use", DataTypes.Text);
        public DbColumn System => AddColumn("system", DataTypes.Text);
        public DbColumn Value => AddColumn("value", DataTypes.Text);
        public DbColumn PeriodStart => AddColumn("period_start", DataTypes.Timestamp);
        public DbColumn PeriodEnd => AddColumn("period_end", DataTypes.Timestamp);

        private readonly PatientTable _patientTable;
        private readonly IdentifierTypeTable _identifierTypeTable;
        
        public PatientIdentifierTable(
            PatientTable patientTable,
            IdentifierTypeTable identifierTypeTable) : base("patient_identifiers")
        {
            _patientTable = patientTable;
            _identifierTypeTable = identifierTypeTable;
        }
    }
}