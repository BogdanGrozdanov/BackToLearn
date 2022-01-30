using System;

namespace BackIn30Minutes
{
    internal class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int afterTime = 30;

            if (minutes + afterTime <= 59)
            {
                minutes += afterTime;
            }
            else
            {
                minutes = (minutes + afterTime) - 60;
                hours += 1;
                if (hours == 24)
                {
                    hours = 0;
                }
            }
            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
