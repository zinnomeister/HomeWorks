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


            Console.WriteLine(Array[^1]);

            Console.ReadLine();



        }
    }
}
