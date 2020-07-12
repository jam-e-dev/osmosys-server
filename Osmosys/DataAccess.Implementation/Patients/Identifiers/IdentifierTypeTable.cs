using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public static class IdentifierTypeTable
    {
        public const string Name = "identifier_types";

        public static readonly DbColumn Pk = new DbColumn("pk", DataTypes.Long);
        public static readonly DbColumn Text = new DbColumn("text", DataTypes.Text);
        public static readonly PrimaryKey PkConstraint = new PrimaryKey(Pk);
    }
}