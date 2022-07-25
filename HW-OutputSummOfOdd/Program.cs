using System;

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

            int SummOdd = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    SummOdd += Array[i];
                }
                
            }
            Console.Write("Summ of odd: \t");
            Console.WriteLine(SummOdd);


            Console.ReadLine();



        }
    }
}



