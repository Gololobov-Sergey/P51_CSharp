using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace P51_CSharp
{
    public partial class Student2
    {
        int id;

        string? firstName;

        string? lastName;

        DateOnly birthDay;

        static string academy;

        public const int number_of_years_study = 4;

        public readonly int number_of_subject;

        public readonly int[] marks = { 10, 11, 12 };

        public Student2()
        {
            this.id = -1;
            firstName = "";
            lastName = "";
            birthDay = new DateOnly(1900, 1, 1);
            number_of_subject = 4;
        }


        public Student2(int id, string fn, string ln, DateOnly bd, int subject)
        {
            this.id = id;
            firstName = fn;
            lastName = ln;
            birthDay = bd;
            number_of_subject = subject;
            MyProperty1 = 10;
        }

        static Student2()
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

        public static void SetAcademy(string new_academy)
        {
            academy = new_academy;
        }

        public void SetID(int id)
        {
            if (id < 0)
                return;
            this.id = id;
        }

        public int GetID()
        {
            return id;
        }


        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set 
            { 
                if(myVar != value)
                    myVar = value; 
            }
        }

        private string temp;

        public string Temp
        {
            get { return temp; }
            set { temp = value; }
        }



        public string Kelvin
        {
            get { return temp; }
            set { temp = value; }
        }

        public int MyProperty1 { get; private set; }
        public int MyProperty2 { get; } = 100;
    }
}
