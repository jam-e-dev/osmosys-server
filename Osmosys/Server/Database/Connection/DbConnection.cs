using System;
using System.Threading.Tasks;
using Npgsql;

namespace Server.Database.Connection
{
    public class DbConnection : Connection
    {
        private static readonly string DbConnStr = $"Server=127.0.0.1;Port=5432;Database={Db.Name};User Id=postgres;Password=password;";
        private NpgsqlTransaction _transaction;
        
        public DbConnection() : base(DbConnStr) {}
        
        public async Task BeginTransactionAsync()
        {
            if (_transaction != null)
            {
                throw new InvalidOperationException("Transaction already active.");
            }

            _transaction = await Current.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("No transaction active.");
            }

            var transaction = _transaction;
            _transaction = null;
            await transaction.CommitAsync();
        }

        public async Task RollbackTransactionAsync()
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