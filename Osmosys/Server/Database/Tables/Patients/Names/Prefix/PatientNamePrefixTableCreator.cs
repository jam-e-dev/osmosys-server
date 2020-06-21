using System.Threading.Tasks;
using Npgsql;
using Server.Database.Connection;

namespace Server.Database.Tables.Patients.Names.Prefix
{
    public class PatientNamePrefixTableCreator : IPatientNamePrefixTableCreator
    {
        private readonly DbConnection _connection;

        public PatientNamePrefixTableCreator(DbConnection connection)
        {
            _connection = connection;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            const string sql = "create table if not exists patient_name_prefixes (pk bigserial primary key, patient_name_fk bigint, foreign key (patient_name_fk) references patient_names(pk), prefix text)";
            await using var cmd = new NpgsqlCommand(sql, _connection.Current);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}