using System;

namespace Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            int countPeoples = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine().ToLower();
            string typeDay = Console.ReadLine().ToLower();

            double totalPrice = 0;

            switch (typeDay)
            {
                case "friday":
                    if (typeGroup == "students")
                    {
                        totalPrice = 8.45 * countPeoples;

                        if (countPeoples >= 30)
                        {
                            totalPrice *= 0.85;
                        }
                    }
                    else if (typeGroup == "business")
                    {
                        totalPrice = 10.90 * countPeoples;

                        if (countPeoples >= 100)
                        {
                            totalPrice = 10.90 * (countPeoples - 10);
                        }
                    }
                    else if (typeGroup == "regular")
                    {
                        totalPrice = 15 * countPeoples;
                        if (countPeoples >= 10 && countPeoples <= 20)
                        {
                            totalPrice *= 95;
                        }
                    }
                    break;
                case "saturday":
                    if (typeGroup == "students")
                    {
                        totalPrice = 9.80 * countPeoples;

                        if (countPeoples >= 30)
                        {
                            totalPrice *= 0.85;
                        }
                    }
                    else if (typeGroup == "business")
                    {
                        totalPrice = 15.60 * countPeoples;

                        if (countPeoples >= 100)
                        {
                            totalPrice = 10.90 * (countPeoples - 10);
                        }
                    }
                    else if (typeGroup == "regular")
                    {
                        totalPrice = 20 * countPeoples;
                        if (countPeoples >= 10 && countPeoples <= 20)
                        {
                            totalPrice *= 95;
                        }
                    }
                    break;
                case "sunday":
                    if (typeGroup == "students")
                    {
                        totalPrice = 10.46 * countPeoples;

                        if (countPeoples >= 30)
                        {
                            totalPrice *= 0.85;
                        }
                    }
                    else if (typeGroup == "business")
                    {
                        totalPrice = 16 * countPeoples;

                        if (countPeoples >= 100)
                        {
                            totalPrice = 10.90 * (countPeoples - 10);
                        }
                    }
                    else if (typeGroup == "regular")
                    {
                        totalPrice = 22.50 * countPeoples;
                        if (countPeoples >= 10 && countPeoples <= 20)
                        {
                            totalPrice *= 95;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
