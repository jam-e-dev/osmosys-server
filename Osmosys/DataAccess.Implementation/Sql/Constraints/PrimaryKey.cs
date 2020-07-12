namespace DataAccess.Implementation.Sql.Constraints
{
    public class PrimaryKey : DbColumn
    {
        public PrimaryKey(string table, string name) : base(table, name, DataTypes.AutoLong)
        {
        }
    }
}