using System;

namespace DesignPatterns.Patterns.Strategy
{
    class StrategyMain
    {
        public void Start()
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());

            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
        }
    }

    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move by Petrol");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move by Electric");
        }
    }

    class Car
    {
        protected int passengers;
        protected string model;

        public Car(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }
}
