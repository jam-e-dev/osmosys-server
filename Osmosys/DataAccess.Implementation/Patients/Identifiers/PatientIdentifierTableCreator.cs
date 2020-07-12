using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Identifiers;

namespace DataAccess.Implementation.Patients.Identifiers
{
    public class PatientIdentifierTableCreator : IPatientIdentifierTableCreator
    {
        private readonly DbTableFactory _factory;

        public PatientIdentifierTableCreator(DbTableFactory factory)
        {
            _factory = factory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            var table = _factory.Create(PatientIdentifierTable.Name);
            
            table.Add(new[]
            {
                PatientIdentifierTable.Pk,
                PatientIdentifierTable.PatientFk,
                PatientIdentifierTable.IdentiferTypeFk,
                PatientIdentifierTable.Use,
                PatientIdentifierTable.System,
                PatientIdentifierTable.Value,
                PatientIdentifierTable.PeriodStart,
                PatientIdentifierTable.PeriodEnd
            });

            table.Add(new[]
            {
                PatientIdentifierTable.PatientFk,
                PatientIdentifierTable.IdentiferTypeFk
            });

            table.Add(PatientIdentifierTable.Pk);

            await table.CreateIfNotExistsAsync();
        }
    }
}