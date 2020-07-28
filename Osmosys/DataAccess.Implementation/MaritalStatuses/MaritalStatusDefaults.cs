using Common.DataTypes;

namespace DataAccess.Implementation.MaritalStatuses
{
    public static class MaritalStatusDefaults
    {
        public static CodeableConcept[] Defaults => new[]
        {
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "A",
                        Display = "Annulled",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Annulled"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "D",
                        Display = "Divorced",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Divorced"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "I",
                        Display = "Interlocutory",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Interlocutory"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "L",
                        Display = "Legally Separated",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Legally separated"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "M",
                        Display = "Married",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Married"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "P",
                        Display = "Polygamous",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Polygamous"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "S",
                        Display = "Never Married",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Never married"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "T",
                        Display = "Domestic partner",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Domestic partner"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "U",
                        Display = "unmarried",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Unmarried"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "W",
                        Display = "Widowed",
                        System = "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Widowed"
            },
            new CodeableConcept
            {
                Coding = new[]
                {
                    new Coding
                    {
                        Code = "UNK",
                        Display = "unknown",
                        System = "	http://terminology.hl7.org/CodeSystem/v3-NullFlavor",
                        UserSelected = false,
                        Version = "2018-08-12"
                    }
                },
                Text = "Unknown"
            }
        };
    }
}