using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts.Addresses
{
    public class PatientContactAddressLineTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public DbColumn Line => AddColumn("line", DataTypes.Text);
        public ForeignKey PatientContactAddressFk => AddForeign("patient_contact_address_fk", _patientContactAddressTable.Pk);

        private readonly PatientContactAddressTable _patientContactAddressTable;
        
        public PatientContactAddressLineTable(PatientContactAddressTable patientContactAddressTable) : base("patient_contact_address_lines")
        {
            _patientContactAddressTable = patientContactAddressTable;
        }
    }
}