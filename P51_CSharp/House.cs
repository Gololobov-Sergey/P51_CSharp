using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    interface IWorker
    {
        void Work();
    }

    interface IPart
    {
        bool IsBuilt { get; set; }
        void Build();
    }

    class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }
    }

    class TeamLead : IWorker
    {
        public void Work()
        {
            Console.WriteLine("TeamLead is working.");
        }
    }


    class Basement : IPart
    {
        public bool IsBuilt { get; set; } = false;

        public void Build()
        {
            Console.WriteLine("Basement is built.");
        }
    }

    class Wall : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Walls are built.");
        }
    }

    class Roof : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Roof is built.");
        }
    }


    class Door : IPart
    {
        public bool IsBuilt { get; set; } = false;
        public void Build()
        {
            Console.WriteLine("Door is built.");
        }
    }

    internal class House
    {
        List<IPart> parts = [new Basement(), new Wall(), new Wall(), new Wall()];
    }
}
