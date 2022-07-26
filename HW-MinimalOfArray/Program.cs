using System;
//using System.Linq; ???

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input quantity of elements:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] Array = new int[elementsCount];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"\nInput value of nt # {i}:\t");//why "$"?
                Array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOutput of Array - Summ of odd:");

            int minValue = Array[0];
            int maxValue = Array[0];

            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] < minValue)
                {
                    minValue = Array[i];
                }

            }
            Console.Write("Minimal value of Array: \t");
            Console.WriteLine(minValue);

            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] > maxValue)
                {
                    maxValue = Array[i];
                }

            }
            Console.Write("Maximal value of Array: \t");
            Console.WriteLine(maxValue);
            Console.Write("\nMinimal Value by short code:\t");
            Console.WriteLine(Array.Min());
            Console.Write("\nMaximal Value by short code:\t");
            Console.WriteLine(Array.Max());

            Console.Write("Summ of evens:\t");                      //Повторить!!!
            Console.WriteLine(Array.Where(i => i % 2 == 0).Sum());  //Повторить!!!
            Console.Write("\nSumm of odds:\t");                     //Повторить!!!
            Console.WriteLine(Array.Where(i => i %2 != 0).Sum());   //Повторить!!!


            Console.ReadLine();



        }
    }
}



