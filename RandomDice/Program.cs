using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number n: ");
            int n = int.Parse(Console.ReadLine());

            Random number = new Random();

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                total += number.Next(1,7);
            }

            Console.WriteLine("Total: " + total);
        }
    }
}