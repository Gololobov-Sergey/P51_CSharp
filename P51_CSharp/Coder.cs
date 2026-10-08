using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CoderAttribute : Attribute
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }


        public CoderAttribute()
        {
            Name = "Gololobov S.A.";
            Date = DateTime.Now;
        }

        public CoderAttribute(string name, string date)
        {
            Name = name;
            Date = DateTime.Parse(date);
        }

        public override string ToString()
        {
            return $"Coder: {Name}, Date: {Date.ToShortDateString()}";
        }
    }
}
