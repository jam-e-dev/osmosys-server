using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.MaritalStatuses
{
    public class MaritalStatusCodingTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey MaritalStatusFk => AddForeign("marital_status_fk", _maritalStatusTable.Pk);
        public DbColumn System => AddColumn("system", DataTypes.Text);
        public DbColumn Version => AddColumn("version", DataTypes.Text);
        public DbColumn Code => AddColumn("code", DataTypes.Text);
        public DbColumn Display => AddColumn("display", DataTypes.Text);
        public DbColumn UserSelected => AddColumn("user_selected", DataTypes.Bool);
        
        private readonly MaritalStatusTable _maritalStatusTable;
        
        public MaritalStatusCodingTable(MaritalStatusTable maritalStatusTable) : base("marital_status_codings")
        {
            _maritalStatusTable = maritalStatusTable;
        }
    }
}