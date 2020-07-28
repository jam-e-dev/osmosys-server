using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Connections;
using DataAccess.Implementation.Sql.Constraints;
using Npgsql;

namespace DataAccess.Implementation.Sql
{
    public class TableBuilder
    {
        public string Name { get; }

        private readonly IDbConnection<NpgsqlConnection> _dbConnection;
        private readonly List<DbColumn> _columns;
        private readonly List<ForeignKey> _foreignKeys;
        private PrimaryKey? _primaryKey;

        public TableBuilder(string tableName, IDbConnection<NpgsqlConnection> dbConnection)
        {
            Name = tableName;
            _dbConnection = dbConnection;
            _columns = new List<DbColumn>();
            _foreignKeys = new List<ForeignKey>();
        }

        public TableBuilder Add(DbColumn column)
        {
            _columns.Add(column);
            return this;
        }

        public TableBuilder Add(ForeignKey foreignKey)
        {
            _foreignKeys.Add(foreignKey);
            return this;
        }

        public TableBuilder Add(PrimaryKey constraint)
        {
            _primaryKey = constraint;
            return this;
        }

        public async Task CreateIfNotExistsAsync()
        {
            var sql = PrepareSql();
            await using var cmd = new NpgsqlCommand(sql, _dbConnection.Current);
            await cmd.ExecuteNonQueryAsync();
        }

        private string PrepareSql()
        {
            var builder = new TableSqlBuilder()
                .CreateIfNotExists(Name);

            foreach (var column in _columns)
            {
                builder.Add(column);
            }

            foreach (var foreignKey in _foreignKeys)
            {
                builder.Add(foreignKey);
            }

            return builder.Add(_primaryKey)
                .ToString();
        }
    }
}