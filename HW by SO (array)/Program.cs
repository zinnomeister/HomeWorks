using System;

using System.Linq;// ???

namespace CharArray
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input words:\n");
            string Char = Console.ReadLine();
            int symbolsCount = Char.Length;
            char[] Array = new char[symbolsCount];
            for (int i = 0; i < symbolsCount; i++)
            {
                Array[i] = Char[i];
            }
            Console.WriteLine("\nList of chars:\n");
            foreach (char currentChar in Array)
            {
                Console.WriteLine(currentChar);
            }
           

            Console.ReadKey();
        }
    }
}
