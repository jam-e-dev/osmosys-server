namespace Server.Database.Tables.Patients.Contacts.Relationships
{
    public static class PatientContactRelationshipDefaults
    {
        public static CodeableConcept[] Defaults => new[]
        {
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "C",
                        Display = "Emergency Contact",
                        System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                        UserSelected = false,
                        Version = "2.9"
                    }
                }
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "E",
                        Display = "Employer",
                        System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                        UserSelected = false,
                        Version = "2.9"
                    }
                }
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "F",
                        Display = "Federal Agency",
                        System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                        UserSelected = false,
                        Version = "2.9"
                    }
                }
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "I",
                        Display = "Insurance Company",
                        System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                        UserSelected = false,
                        Version = "2.9"
                    }
                }
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "N",
                        Display = "Next-of-Kin",
                        System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                        UserSelected = false,
                        Version = "2.9"
                    }
                }
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "S",
                        Display = "State Agency",
                        System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                        UserSelected = false,
                        Version = "2.9"
                    }
                }
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "U",
                        Display = "Unknown",
                        System = "http://terminology.hl7.org/CodeSystem/v2-0131",
                        UserSelected = false,
                        Version = "2.9"
                    }
                }
            },
        };
    }
}