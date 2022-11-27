using System.Numerics;

namespace ExactSumOFRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < numberOfInputs; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}