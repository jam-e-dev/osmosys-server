using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Identifiers;
using DataAccess.Patients.Identifiers.Types;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public class IdentifierTypeTableCreator : IIdentifierTypeTableCreator
    {
        private readonly DbTableFactory _factory;

        public IdentifierTypeTableCreator(DbTableFactory factory)
        {
            _factory = factory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            var table = _factory.Create(IdentifierTypeTable.Name);
            
            table.Add(new[]
            {
                IdentifierTypeTable.Pk,
                IdentifierTypeTable.Text
            });

            table.Add(IdentifierTypeTable.PkConstraint);

            await table.CreateIfNotExistsAsync();
        }
    }
}