using System;
namespace PoundsToDollars
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal dolarPerPound = 1.31M;
            decimal output = input * dolarPerPound;

            Console.WriteLine($"{output:F3}");
        }
    }
}