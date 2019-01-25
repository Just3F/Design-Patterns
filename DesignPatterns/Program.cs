using System;
using DesignPatterns.Patterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyMain example = new StrategyMain();
            example.Start();

            Console.Read();
        }
    }
}