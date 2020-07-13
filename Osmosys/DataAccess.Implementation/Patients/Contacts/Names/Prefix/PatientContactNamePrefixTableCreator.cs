﻿using System.Threading.Tasks;
using DataAccess.Implementation.Sql;
using DataAccess.Patients.Contacts.Names.Prefix;

namespace DataAccess.Implementation.Patients.Contacts.Names.Prefix
{
    public class PatientContactNamePrefixTableCreator : IPatientContactPrefixTableCreator
    {
        private readonly PatientContactNamePrefixTable _table;
        private readonly TableBuilderFactory _builderFactory;

        public PatientContactNamePrefixTableCreator(
            PatientContactNamePrefixTable table,
            TableBuilderFactory builderFactory)
        {
            _table = table;
            _builderFactory = builderFactory;
        }
        
        public async Task CreateIfNotExistsAsync()
        {
            await _builderFactory.Create(_table.TblName)
                .Add(_table.Pk)
                .Add(_table.PatientNameFk)
                .Add(_table.Prefix)
                .CreateIfNotExistsAsync();
        }
    }
}