using DataAccess.Implementation.Sql;
using DataAccess.Implementation.Sql.Constraints;

namespace DataAccess.Implementation.Patients.Addresses
{
    public class PatientAddressLineTable : TableDefinition
    {
        public PrimaryKey Pk => AddPrimary("pk");
        public DbColumn Line => AddColumn("line", DataTypes.Text);
        public ForeignKey PatientAddressFk => AddForeign("patient_address_fk", _patientAddressTable.Pk);

        private readonly PatientAddressTable _patientAddressTable;
        
        public PatientAddressLineTable(PatientAddressTable patientAddressTable) : base("patient_address_lines")
        {
            _patientAddressTable = patientAddressTable;
        }
    }
}