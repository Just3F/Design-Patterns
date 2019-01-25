using System;
using DesignPatterns.Patterns.Strategy;
using DesignPatterns.Patterns.TemplateMethod;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample example = new TemplateMethodMain();
            example.Start();

            Console.Read();
        }
    }

    interface IExample
    {
        void Start();
    }
}