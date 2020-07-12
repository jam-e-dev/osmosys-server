using DataAccess.Implementation.Patients.Identifiers.Types;
using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public static class PatientIdentifierTable
    {
        public const string Name = "patient_identifiers";

        public static readonly DbColumn Pk = new DbColumn("pk", DataTypes.Long);
        public static readonly DbColumn PatientFk = new DbColumn("patient_fk", DataTypes.Long);
        public static readonly DbColumn IdentiferTypeFk = new DbColumn("identifier_type_fk", DataTypes.Long);
        public static readonly DbColumn Use = new DbColumn("use", DataTypes.Text);
        public static readonly DbColumn System = new DbColumn("system", DataTypes.Text);
        public static readonly DbColumn Value = new DbColumn("value", DataTypes.Text);
        public static readonly DbColumn PeriodStart = new DbColumn("period_start", DataTypes.Timestamp);
        public static readonly DbColumn PeriodEnd = new DbColumn("period_end", DataTypes.Timestamp);

        public static readonly PrimaryKey PkConstraint = new PrimaryKey(Pk);
        public static readonly ForeignKey PatientFkConstraint = new ForeignKey("patients", PatientColumns.Pk, PatientFk);
        public static readonly ForeignKey IdentifierTypeFkConstraint = new ForeignKey("identifier_types", IdentifierTypeTable.Pk, IdentiferTypeFk);
    }
}