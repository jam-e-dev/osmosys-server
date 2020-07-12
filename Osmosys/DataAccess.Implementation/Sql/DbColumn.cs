namespace DataAccess.Implementation.Sql
{
    public class DbColumn
    {
        public string Table { get; }
        public string Name { get; }
        public DataTypes Type { get; }
        
        public DbColumn(string table, string columnName, DataTypes type)
        {
            Table = table;
            Name = columnName;
            Type = type;
        }
    }
}