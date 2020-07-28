using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.MaritalStatuses
{
    public class MaritalStatusTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public DbColumn Text => AddColumn("text", DataTypes.Text);
        
        public MaritalStatusTable(string tblName) : base(tblName)
        {
        }
    }
}