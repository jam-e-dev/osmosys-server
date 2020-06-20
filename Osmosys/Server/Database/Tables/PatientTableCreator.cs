using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables
{
    public class PatientTableCreator : IPatientTableCreator
    {
        private readonly DbConnection _connection;

        public PatientTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists (pk bigserial primary key, active boolean, gender text, birth_date date, deceased boolean, deceased_date_time timestamp)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}