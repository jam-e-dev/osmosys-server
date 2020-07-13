using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Names.Given
{
    public class PatientContactGivenNameTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientContactNameFk => AddForeign("patient_contact_name_fk", _patientContactNameTable.Pk);
        public DbColumn Name => AddColumn("name", DataTypes.Text);

        private readonly PatientContactNameTable _patientContactNameTable;

        public PatientContactGivenNameTable(PatientContactNameTable patientContactNameTable) : base("patient_contact_given_names")
        {
            _patientContactNameTable = patientContactNameTable;
        }
    }
}