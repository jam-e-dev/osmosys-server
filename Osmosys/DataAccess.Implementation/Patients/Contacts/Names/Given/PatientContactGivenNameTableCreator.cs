using System.Threading.Tasks;
using DataAccess.Implementation.Connection;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Contacts.Names.Given;
using Npgsql;

namespace DataAccess.Implementation.Patients.Contacts.Names.Given
{
    public class PatientContactGivenNameTableCreator : IPatientContactGivenNameTableCreator
    {
        private readonly PatientContactGivenNameTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public PatientContactGivenNameTableCreator(
            PatientContactGivenNameTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientContactNameFk)
                .Add(_table.Name)
                .CreateIfNotExistsAsync();
        }
    }
}