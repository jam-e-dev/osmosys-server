using System.Threading.Tasks;
using DataAccess.Patients.MaritalStatuses;

namespace DataAccess.Implementation.Patients.MaritalStatuses
{
    public class MaritalStatusStorage : IMaritalStatusStorage
    {
        private readonly IMaritalStatusTableCreator _maritalStatusTableCreator;
        private readonly IMaritalStatusCodingTableCreator _maritalStatusCodingTableCreator;

        public MaritalStatusStorage(
            IMaritalStatusTableCreator maritalStatusTableCreator,
            IMaritalStatusCodingTableCreator maritalStatusCodingTableCreator)
        {
            _maritalStatusTableCreator = maritalStatusTableCreator;
            _maritalStatusCodingTableCreator = maritalStatusCodingTableCreator;
        }
        
        public async Task InitAsync()
        {
            await _maritalStatusTableCreator.CreateIfNotExistsAsync();
            await _maritalStatusCodingTableCreator.CreateIfNotExistsAsync();
        }
    }
}