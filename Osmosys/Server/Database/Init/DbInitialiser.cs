using System;
using System.Threading.Tasks;
using Server.Database.Connection;
using Server.Database.Tables;

namespace Server.Database.Init
{
    public class DbInitialiser : IDbInitialiser
    {
        private readonly DbConnection _dbConnection;
        private readonly ServerConnection _serverConnection;
        private readonly IDbVerifier _dbVerifier;
        private readonly IDbCreator _dbCreator;
        private readonly ITableInitialiser _tableInitialiser;

        public DbInitialiser(
            DbConnection dbConnection,
            ServerConnection serverConnection,
            IDbVerifier dbVerifier,
            IDbCreator dbCreator,
            ITableInitialiser tableInitialiser)
        {
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
                await _dbConnection.BeginTransactionAsync();

                try
                {
                    await _tableInitialiser.InitAsync();
                    await _dbConnection.CommitTransactionAsync();
                }
                catch
                {
                    await _dbConnection.RollbackTransactionAsync();
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