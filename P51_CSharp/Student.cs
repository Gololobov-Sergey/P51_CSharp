using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace P51_CSharp
{
    public partial class Student
    {
        int id;

        string? firstName;

        string? lastName;

        DateOnly birthDay;

        static string academy;

        public const int number_of_years_study = 4;

        public readonly int number_of_subject;

        public readonly int[] marks = { 10, 11, 12 };

        public Student()
        {
            this.id = -1;
            firstName = "";
            lastName = "";
            birthDay = new DateOnly(1900, 1, 1);
            number_of_subject = 4;
        }


        public Student(int id, string fn, string ln, DateOnly bd, int subject)
        {
            this.id = id;
            firstName = fn;
            lastName = ln;
            birthDay = bd;
            number_of_subject = subject;
        }

        static Student()
        {
            academy = "IT STEP";
        }

        public void Print()
        {
            Console.WriteLine($"Id - {id}, FirstName - {firstName}, LastName - {lastName}, BD - {birthDay}, Subject - {number_of_subject}");
        }

        public static string GetAcademy()
        {
            return academy;
        }

        //public static void SetAcademy(string new_academy)
        //{
        //    academy = new_academy;
        //}
    }
}
