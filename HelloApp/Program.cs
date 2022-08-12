using System;
using MyCalc;
namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            
            Calc calc = new Calc();

            Console.WriteLine($"Sum = {calc.Add(70,80)}");
            Console.WriteLine($"Multiply = {calc.Multiply(4,5)}");
            Console.WriteLine($"Substract = {calc.Multiply(5,3)}");
            Console.ReadLine();
        }
    }
}
