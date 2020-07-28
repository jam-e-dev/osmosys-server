using System;
using System.Threading.Tasks;
using Npgsql;

namespace DataAccess.Implementation.Connections
{
    public abstract class ConnectionBase
    {
        private readonly string _connectionString;
        private NpgsqlConnection? _current;

        public NpgsqlConnection Current => _current ?? throw new InvalidOperationException("No DB connection active.");

        protected ConnectionBase(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task OpenAsync()
        {
            if (_current != null)
            {
                throw new InvalidOperationException("DB connection already open.");
            }
            
            var conn = new NpgsqlConnection(_connectionString);
            await conn.OpenAsync();

            _current = conn;
        }
        
        public async Task CloseAsync()
        {
            if (_current == null)
            {
                throw new InvalidOperationException("No DB connection active.");
            }

            var current = _current;
            _current = null;
            await current.DisposeAsync();
        }
    }
}