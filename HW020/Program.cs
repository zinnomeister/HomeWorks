using System;

namespace HW020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW 020");

            uint oddCount = 0; //нечётные
            uint evenCount = 0; //чётные

            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Input start value");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Input ending value");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenCount++;
                    evenSum += currentValue;
                }
                else
                {
                    oddCount++;
                    oddSum = oddSum + currentValue;
                }
                currentValue++;
            }
            Console.WriteLine("Quantity of odds: " + oddCount);
            Console.WriteLine("Quantity of evens: " + evenCount);
            Console.WriteLine("Sum of odds: " + oddSum);
            Console.WriteLine("Sum of evens: " + evenSum);

            Console.ReadLine();
        }
    }
}