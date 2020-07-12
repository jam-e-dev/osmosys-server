namespace DataAccess.Implementation.Sql.Constraints
{
    public class ForeignKey : DbColumn
    {
        public PrimaryKey Referenced { get; }
        
        public ForeignKey(
            string table,
            string columnName,
            PrimaryKey referenced) : base(table, columnName, DataTypes.Long)
        {
            Referenced = referenced;
        }
    }
}