﻿using DataAccess.Connection;
using Npgsql;

namespace DataAccess.Implementation.Sql
{
    public class TableBuilderFactory
    {
        private readonly IDatabaseConnection<NpgsqlConnection> _connection;

        public TableBuilderFactory(IDatabaseConnection<NpgsqlConnection> connection)
        {
            _connection = connection;
        }
        
        public TableBuilder Create(string tableName) => new TableBuilder(tableName, _connection); 
    }
}