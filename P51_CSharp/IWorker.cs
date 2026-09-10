using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    internal interface IWorker
    {
        bool IsWorking { get; set; }
        void Work();
    }


    interface IManager
    {
        void Manage();
    }

    class Prorab : IWorker
    {
        public bool IsWorking { get; set; }
        public void Work()
        {
            if (IsWorking)
            {
                Console.WriteLine("Prorab is working.");
            }
            else
            {
                Console.WriteLine("Prorab is not working.");
            }
        }
    }

    class Director2 : IWorker, IManager
    {
        public bool IsWorking { get; set; }

        public void Work()
        {
            if (IsWorking)
            {
                Console.WriteLine("Director is working.");
            }
            else
            {
                Console.WriteLine("Director is not working.");
            }
        }

        public void Manage()
        {
            Console.WriteLine("Director is managing.");
        }
    }


    //interface IA
    //{
    //    string A1();
    //}

    //interface IB
    //{
    //    string B1(int a);
    //}

    //interface IC : IA, IB
    //{
    //    string C1();
    //}

    //class MyClass : IC
    //{
    //    public string A1()
    //    {
    //        return "A1";
    //    }
    //    public string B1(int a)
    //    {
    //        return $"B1: {a}";
    //    }
    //    public string C1()
    //    {
    //        return "C1";
    //    }
    //}


    interface IA
    {
        void Show();
    }

    interface IB
    {
        void Show();
    }

    interface IC
    {
        void Show();
    }

    class MyClass2 : IA, IB, IC
    {

        public void Show()
        {
            Console.WriteLine("Show from MyClass2");
        }
        void IA.Show()
        {
            Console.WriteLine("Show from IA");
        }

        void IB.Show()
        {
            Console.WriteLine("Show from IB");
        }
    }
}
