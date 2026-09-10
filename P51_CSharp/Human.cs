using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    abstract class Human
    {
        int id;
        string firstName;
        string lastName;

        public Human(int id, string fn, string ln)
        {
            this.id = id;
            firstName = fn;
            lastName = ln;
        }

        //public virtual void Print()
        //{
        //    Console.WriteLine($"Human: {id}, {firstName}, {lastName}");
        //}

        public abstract void Work(); // Abstract method, must be implemented in derived classes

        public override string ToString()
        {
            return $"Human: {id}, {firstName}, {lastName}";
        }

        public void ShowHuman()
        {
            Console.WriteLine($"Human: {id}, {firstName}, {lastName}");
        }

    }


    /*sealed*/ class Employee : Human
    {
        int salary;

        public Employee(int id, string fn, string ln, int sal) : base(id, fn, ln)
        {
            salary = sal;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nEmployee: {salary} $";
        }
        

        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Employee: {salary} $");
        //}

        public void ShowEmployee()
        {
            base.ShowHuman();
            Console.WriteLine($"Employee: {salary} $");
        }

        public override void Work()
        {
            Console.WriteLine("Employee works");
        }
    }

    class Director : Employee
    {
        int bonus;
        public Director(int id, string fn, string ln, int sal, int bon) : base(id, fn, ln, sal)
        {
            bonus = bon;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDirector: {bonus} $";
        }

        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Director: {bonus} $");
        //}

        public void ShowDirector()
        {
            base.ShowEmployee();
            Console.WriteLine($"Director: {bonus} $");
        }
    }


    class Programmer : Human
    {
        string programmingLanguage;
        public Programmer(int id, string fn, string ln, string pl) : base(id, fn, ln)
        {
            programmingLanguage = pl;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nProgrammer: {programmingLanguage}";
        }

        public override void Work()
        {
            Console.WriteLine("Programmer make code");
        }
    }

}
