using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public static class IdentifierTypeCodingTable
    {
        public const string Name = "identifier_type_codings";

        public static readonly DbColumn Pk = new DbColumn("pk", DataTypes.Long);
        public static readonly DbColumn IdentifierTypeFk = new DbColumn("identifier_type_fk", DataTypes.Long);
        public static readonly DbColumn System = new DbColumn("system", DataTypes.Text);
        public static readonly DbColumn Version = new DbColumn("version", DataTypes.Text);
        public static readonly DbColumn Code = new DbColumn("code", DataTypes.Text);
        public static readonly DbColumn Display = new DbColumn("display", DataTypes.Text);
        public static readonly DbColumn UserSelected = new DbColumn("user_selected", DataTypes.Bool);

        public static readonly PrimaryKey PkConstraint = new PrimaryKey(Pk);
        public static readonly ForeignKey IdentifierTypeFkConstraint = new ForeignKey(IdentifierTypeTable.Name, IdentifierTypeTable.Pk, IdentifierTypeFk);
    }
}