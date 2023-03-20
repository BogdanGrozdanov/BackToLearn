namespace DefaultValues
{
    internal class DefaultValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input start number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Input end number");
            int end = int.Parse(Console.ReadLine());
            PrintNumber(start, end);
        }
        static void PrintNumber(int start,int end) 
        {
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                if (i == end)
                {
                    Console.Write($"{i}");
                }
                else 
                { Console.Write($"{i}, "); } 

                counter++;
            }
            Console.WriteLine(  );
            Console.WriteLine($"Count number is: {counter}.");
        }

    }
}