using System.Threading.Tasks;
using DataAccess.Implementation.Connection;
using DataAccess.Patients.Identifiers;
using DataAccess.Patients.Identifiers.Types;
using Npgsql;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeRecordReader : IIdentifierTypeRecordReader
    {
        private readonly DbDatabaseConnection _databaseConnection;

        public IdentifierTypeRecordReader(DbDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        
        public async Task<long> CountAsync()
        {
            const string sql = "select count(*) from identifier_types";
            await using var cmd = new NpgsqlCommand(sql, _databaseConnection.Current);
            return (long) await cmd.ExecuteScalarAsync();
        }
    }
}