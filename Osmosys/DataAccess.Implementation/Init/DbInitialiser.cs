using System.Data;
using System.Threading.Tasks;
using DataAccess.Connections;
using DataAccess.Implementation.Connections;
using DataAccess.Init;
using Npgsql;

namespace DataAccess.Implementation.Init
{
    public class DbInitialiser : IDbInitialiser
    {
        private readonly ITransaction _transaction;
        private readonly IDbConnection<NpgsqlConnection> _dbConnection;
        private readonly ServerConnection _serverConnection;
        private readonly IDbVerifier _dbVerifier;
        private readonly IDbCreator _dbCreator;
        private readonly ITableInitialiser _tableInitialiser;

        public DbInitialiser(
            ITransaction transaction,
            IDbConnection<NpgsqlConnection> dbConnection,
            ServerConnection serverConnection,
            IDbVerifier dbVerifier,
            IDbCreator dbCreator,
            ITableInitialiser tableInitialiser)
        {
            _transaction = transaction;
            _dbConnection = dbConnection;
            _serverConnection = serverConnection;
            _dbVerifier = dbVerifier;
            _dbCreator = dbCreator;
            _tableInitialiser = tableInitialiser;
        }

        public async Task InitAsync()
        {
            await InitDbAsync();
            await InitTablesAsync();
        }

        private async Task InitDbAsync()
        {
            await _serverConnection.OpenAsync();

            try
            {
                if (!await _dbVerifier.VerifyAsync())
                {
                    await _dbCreator.CreateAsync();
                }
            }
            finally
            {
                await _serverConnection.CloseAsync();
            }
        }

        private async Task InitTablesAsync()
        {
            await _dbConnection.OpenAsync();

            try
            {
                await _transaction.BeginAsync();

                try
                {
                    await _tableInitialiser.InitAsync();
                    await _transaction.CommitAsync();
                }
                catch
                {
                    await _transaction.RollbackAsync();
                    throw;
                }
            }
            finally
            {
                await _dbConnection.CloseAsync();
            }
        }
    }
}