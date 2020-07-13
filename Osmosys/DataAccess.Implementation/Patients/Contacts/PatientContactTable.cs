using DataAccess.Implementation.Patients.Contacts.Addresses;
using DataAccess.Implementation.Patients.Contacts.Names;
using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Contacts
{
    public class PatientContactTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public ForeignKey PatientFk => AddForeign("patient_fk", _patientTable.Pk);
        public ForeignKey PatientContactNameFk => AddForeign("patient_contact_name_fk", _patientContactNameTable.Pk);
        public ForeignKey PatientContactAddressFk => AddForeign("patient_contact_address_fk", _patientContactAddressTable.Pk);
        public DbColumn Gender => AddColumn("gender", DataTypes.Text);
        public DbColumn PeriodStart => AddColumn("period_start", DataTypes.Timestamp);
        public DbColumn PeriodEnd => AddColumn("period_end", DataTypes.Timestamp);

        private readonly PatientTable _patientTable;
        private readonly PatientContactNameTable _patientContactNameTable;
        private readonly PatientContactAddressTable _patientContactAddressTable;
        
        public PatientContactTable(
            PatientTable patientTable,
            PatientContactNameTable patientContactNameTable,
            PatientContactAddressTable patientContactAddressTable) : base("patient_contacts")
        {
            _patientTable = patientTable;
            _patientContactNameTable = patientContactNameTable;
            _patientContactAddressTable = patientContactAddressTable;
        }
    }
}