﻿using System;

namespace SumOfOddNumbers
{
    internal class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n*2; i ++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
