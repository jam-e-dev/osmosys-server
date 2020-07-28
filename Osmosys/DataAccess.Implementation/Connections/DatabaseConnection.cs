using System;
using System.Threading.Tasks;
using DataAccess.Connections;
using Npgsql;

namespace DataAccess.Implementation.Connections
{
    public class DatabaseConnection : ConnectionBase, ITransaction, IDbConnection<NpgsqlConnection>
    {
        private static readonly string DbConnStr = $"Server=127.0.0.1;Port=5432;Database={Db.Name};User Id=postgres;Password=password;";
        private NpgsqlTransaction? _transaction;
        
        public DatabaseConnection() : base(DbConnStr) {}
        
        public async Task BeginAsync()
        {
            if (_transaction != null)
            {
                throw new InvalidOperationException("Transaction already active.");
            }

            _transaction = await Current.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("No transaction active.");
            }

            var transaction = _transaction;
            _transaction = null;
            await transaction.CommitAsync();
        }

        public async Task RollbackAsync()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("No transaction active.");
            }

            var transaction = _transaction;
            _transaction = null;
            await transaction.RollbackAsync();
        }
    }
}