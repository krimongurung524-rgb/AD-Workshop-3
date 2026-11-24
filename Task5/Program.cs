using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: for loop, sum from 1 to N
            Console.Write("Enter a number N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {n} = {sum}");

            // Part 2: while loop, 1 to 20, skip multiples of 4, stop at 15
            Console.WriteLine("\nWhile loop output:");
            int num = 0;
            while (num < 20)
            {
                num++;

                if (num % 4 == 0)
                {
                    continue;   // skip multiples of 4
                }

                if (num == 15)
                {
                    break;      // stop at 15
                }

                Console.WriteLine(num);
            }

            // Part 3: foreach, sum of array elements
            int[] numbers = { 3, 7, 12, 5, 9 };
            int total = 0;
            foreach (int x in numbers)
            {
                total += x;
            }
            Console.WriteLine($"\nSum of array elements = {total}");
        }
    }
}