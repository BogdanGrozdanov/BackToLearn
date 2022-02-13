using System;
using System.Collections.Generic;

namespace Login
{
    internal class Login
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            int count = 0;

            while (true)
            {
                string currentUsser = Console.ReadLine();
                if (currentUsser == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;

                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    count++;
                }
                if (count == 3)
                {
                    Console.WriteLine($"User {userName} blocked! ");
                    break;
                }
            }
        }
    }
}
