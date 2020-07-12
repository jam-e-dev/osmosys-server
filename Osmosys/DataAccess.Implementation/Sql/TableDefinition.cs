using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Sql
{
    public abstract class TableDefinition
    {
        public string TblName { get; }

        protected TableDefinition(string tblName)
        {
            TblName = tblName;
        }
        
        protected DbColumn AddColumn(string name, DataTypes type) => new DbColumn(TblName, name, type);

        protected ForeignKey AddForeign(string name, PrimaryKey referenced) => new ForeignKey(TblName, name, referenced);
        
        protected PrimaryKey AddPrimary(string name) => new PrimaryKey(TblName, name);
    }
}