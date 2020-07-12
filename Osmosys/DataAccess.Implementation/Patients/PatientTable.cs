using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients
{
    public class PatientTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");

        public PatientTable() : base("patients")
        {
        }
    }
}