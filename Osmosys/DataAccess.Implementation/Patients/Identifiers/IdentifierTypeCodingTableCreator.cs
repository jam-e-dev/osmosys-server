using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Identifiers;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public class IdentifierTypeCodingTableCreator : IIdentifierTypeCodingTableCreator
    {
        private readonly DbTableFactory _factory;

        public IdentifierTypeCodingTableCreator(DbTableFactory factory)
        {
            _factory = factory;
        }

        public async Task CreateIfNotExistsAsync()
        {
            var table = _factory.Create(IdentifierTypeTable.Name);
            
            table.Add(new[]
            {
                IdentifierTypeCodingTable.Pk,
                IdentifierTypeCodingTable.IdentifierTypeFk,
                IdentifierTypeCodingTable.System,
                IdentifierTypeCodingTable.Version,
                IdentifierTypeCodingTable.Code,
                IdentifierTypeCodingTable.Display,
                IdentifierTypeCodingTable.UserSelected
            });

            table.Add(new[]
            {
                IdentifierTypeCodingTable.IdentifierTypeFkConstraint
            });

            table.Add(IdentifierTypeCodingTable.PkConstraint);

            await table.CreateIfNotExistsAsync();
        }
    }
}