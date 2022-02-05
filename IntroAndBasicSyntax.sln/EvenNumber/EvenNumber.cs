using System;

namespace EvenNumber
{
    internal class EvenNumber
    {
        static void Main(string[] args)
        {
            int evenNum = int.Parse(Console.ReadLine());

            while (evenNum % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                evenNum=int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {evenNum}");
           
        }
    }
}
