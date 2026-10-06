using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    using System;
    using System.Collections.Generic;

    public class Firma
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string Director { get; set; }
        public int EmployeesCount { get; set; }
        public string Address { get; set; }

        public Firma() { }

        public Firma(string name, DateTime foundationDate,
                     string businessProfile, string director,
                     int employeesCount, string address)
        {
            Name = name;
            FoundationDate = foundationDate;
            BusinessProfile = businessProfile;
            Director = director;
            EmployeesCount = employeesCount;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Name,-20} | {FoundationDate:dd.MM.yyyy} | " +
                   $"{BusinessProfile,-24} | {Director,-30} | " +
                   $"{EmployeesCount,4} | {Address}";
        }
    }

}
