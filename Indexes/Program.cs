using System;

using System.Linq;// ???

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


            Console.Write("\nFirst element:\t");
            Console.WriteLine(Array[0]);
           
            Console.Write("\nLast element:\t");
            Console.WriteLine(Array[^1]);
           
            Console.Write("\nMinimal range:\t");
            Console.WriteLine(Array.Min());
           
            Console.Write("\nMaximal range:\t");
            Console.WriteLine(Array.Max());
            
            Console.Write("\nSumm of elements:\t");
            Console.WriteLine(Array.Sum());
           
            Console.Write("\nSumm of even elements:\t");
            Console.WriteLine(Array.Where(i => i % 2 == 0).Sum());
           
            Console.Write("\nSumm of odd elements:\t");
            Console.WriteLine(Array.Where(i => i % 2 != 0).Sum());
           
            Console.WriteLine("\nSort elements by ascending order:");
            int[] ArrayUp = Array.OrderBy(i => i).ToArray();
            for (int i = 0; i < ArrayUp.Length; i++)
                Console.WriteLine("\n" + ArrayUp[i]);
            
            Console.Write("\nSort elements by descending order:\t");
            int[] ArrayDown = Array.OrderByDescending(i => i).ToArray();
            for (int i = ArrayDown.Length - 1; i >= 0; i--)
            
                Console.WriteLine(ArrayDown[i]);
            




            Console.ReadLine();



        }
    }
}
