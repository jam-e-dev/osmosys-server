using Common.DataTypes;

namespace DataAccess.Implementation.Patients.Identifiers.Types
{
    public static class IdentifierTypeDefaults
    {
        public static CodeableConcept[] Defaults => new[]
        {
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "DL",
                        Display = "Driver's license number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "PPN",
                        Display = "Passport number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "BRN",
                        Display = "Breed Registry Number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "MR",
                        Display = "Medical record number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "MCN",
                        Display = "Microchip Number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "EN",
                        Display = "Employee number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "TAX",
                        Display = "Tax ID number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "NIIP",
                        Display = "National Insurance Payor Identifier (Payor)"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "PRN",
                        Display = "Provider number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "MD",
                        Display = "Medical License number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "DR",
                        Display = "Donor Registration Number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "ACSN",
                        Display = "Accession ID"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "UDI",
                        Display = "Universal Device Identifier"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "SNO",
                        Display = "Serial Number"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "SB",
                        Display = "Social Beneficiary Identifier"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "PLAC",
                        Display = "Placer Identifier"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "FILL",
                        Display = "Filler Identifier"
                    },
                    new Coding
                    {
                        System = "http://terminology.hl7.org/CodeSystem/v2-0203",
                        Version = "2.9",
                        UserSelected = false,
                        Code = "JHN",
                        Display = "Jurisdictional health number (Canada)"
                    },
                },
                Text = ""
            }
        };
    }
}