using System;

namespace PrintAndSum
{
    internal class PrintAndSum
    {
        static void Main(string[] args)
        {
            int startNun = int.Parse(Console.ReadLine());
            int endNun = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = startNun; i <= endNun; i++)
            {
                Console.Write($" {i}");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
