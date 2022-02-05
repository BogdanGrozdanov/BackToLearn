using System;

namespace ForeignLanguages
{
    internal class ForeignLanguages
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine().ToLower();

            switch (country)
            {
                case "england":
                case "usa":
                    Console.WriteLine("English");
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
