using System;
using DesignPatterns.Patterns.Observer;
using DesignPatterns.Patterns.Strategy;
using DesignPatterns.Patterns.TemplateMethod;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample example = new ObserverMain();
            example.Start();

            Console.Read();
        }
    }

    interface IExample
    {
        void Start();
    }
}