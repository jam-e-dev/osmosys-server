using DataAccess.Implementation.Sql;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeCodingTable : TableDefinition
    {
        public DbColumn Pk => AddPrimary("pk");
        public DbColumn IdentifierTypeFk => AddForeign("identifier_type_fk", _identifierTypeTable.Pk);
        public DbColumn System => AddColumn("system", DataTypes.Text);
        public DbColumn Version => AddColumn("version", DataTypes.Text);
        public DbColumn Code => AddColumn("code", DataTypes.Text);
        public DbColumn Display => AddColumn("display", DataTypes.Text);
        public DbColumn UserSelected => AddColumn("user_selected", DataTypes.Bool);

        private readonly IdentifierTypeTable _identifierTypeTable;
        
        public IdentifierTypeCodingTable(IdentifierTypeTable identifierTypeTable) : base("identifier_type_codings")
        {
            _identifierTypeTable = identifierTypeTable;
        }
    }
}