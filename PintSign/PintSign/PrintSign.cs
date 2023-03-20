namespace PrintSign
{
    internal class PrintSign
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            PrintSing(number);
            //PrintEvenOrOdd(number);
        }

        static void PrintSing(int number) 
        {
            if (number < 0) { Console.WriteLine($"The number {number} is negative."); }
            else if (number > 0) { Console.WriteLine($"The number {number} is positive."); }
            else { Console.WriteLine($"The number {number} is zero."); }
        }
        //static void PrintEvenOrOdd(int number)
        //{
        //    if (number % 2 == 0) { Console.WriteLine($"{number} is even."); }
        //    else { Console.Write($"{number} is odd."); }
        //}
    }
}