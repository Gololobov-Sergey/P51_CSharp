using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    public class Student
    {
        public string? FirstName { get; set; } = "No name";
        public string? LastName { get; set; } = "No name";
        public DateOnly BirthDay { get; set; } = new DateOnly(1900,1,1);

        public void Print()
        {
            Console.WriteLine($"{LastName,-20} {FirstName, -15} {BirthDay}");
        }
    }
}
