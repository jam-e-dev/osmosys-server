using System;
using System.Text;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Sql
{
    public class TableSqlBuilder
    {
        private readonly StringBuilder _builder;

        private bool _isTableSet;
        private bool _containsAtLeastOneDefinition;

        public TableSqlBuilder()
        {
            _builder = new StringBuilder();
        }

        public TableSqlBuilder CreateIfNotExists(string table)
        {
            ValidateTableNotSet(_isTableSet);
            _builder.Append("create table if not exists ")
                .Append(table)
                .Append(" (");
            _isTableSet = true;
            return this;
        }
        
        public TableSqlBuilder Add(PrimaryKey? primaryKey)
        {
            if (primaryKey != null)
            {
                AppendSeparator();
                
                _builder.Append("primary key (")
                    .Append(primaryKey.Name);
            }

            return this;
        }
        
        public TableSqlBuilder Add(DbColumn column)
        {
            AppendSeparator();
            _builder.Append(column.Name)
                .Append(" ")
                .Append(ToStr(column.Type));

            return this;
        }
        
        private TableSqlBuilder Add(ForeignKey constraint)
        {
            AppendSeparator();
            _builder.Append(constraint.Name)
                .Append(" ")
                .Append(ToStr(constraint.Type))
                .Append(" references ")
                .Append(constraint.Referenced.Table)
                .Append("(")
                .Append(constraint.Referenced.Name)
                .Append(")");
            return this;
        }

        private static string ToStr(DataTypes type)
        {
            return type switch
            {
                DataTypes.Text => "text",
                DataTypes.Int => "int",
                DataTypes.Long => "bigint",
                DataTypes.Bool => "boolean",
                DataTypes.Timestamp => "timestamp",
                DataTypes.AutoLong => "bigserial",
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }

        private static void ValidateTableNotSet(bool value)
        {
            if (value)
            {
                throw new ArgumentException("Table is already set.");
            }
        }

        private void AppendSeparator()
        {
            if (_containsAtLeastOneDefinition)
            {
                _builder.Append(", ");
            }
            else
            {
                _containsAtLeastOneDefinition = true;
            }
        }

        public override string ToString() => _builder.ToString();
    }
}