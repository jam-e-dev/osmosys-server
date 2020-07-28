using System.Threading.Tasks;
using DataAccess.Implementation.Patients.Contacts.Relationships;
using DataAccess.Implementation.Patients.Identifiers;
using DataAccess.Init;
using DataAccess.MaritalStatuses;
using DataAccess.Patients.Contacts.Relationships;
using DataAccess.Patients.Identifiers;
using DataAccess.Patients.Identifiers.Types;

namespace DataAccess.Implementation.Init
{
    public class  TableInitialiser : ITableInitialiser
    {
        private readonly IMaritalStatusStorage _maritalStatusStorage;

        public TableInitialiser(
            IMaritalStatusStorage maritalStatusStorage)
        {
            _maritalStatusStorage = maritalStatusStorage;
        }
        
        public async Task InitAsync()
        {
            await _maritalStatusStorage.InitAsync();
        }
    }
}