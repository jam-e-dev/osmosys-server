using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public  DbColumn Text => AddColumn("text", DataTypes.Text);

        public IdentifierTypeTable() : base("identifier_types")
        {
        }
    }
}