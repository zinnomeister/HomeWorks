using System;
using System.Linq;

namespace Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your array:\n");
            int []codeArray = new[] { 12, 65, 3, 67, 568, 395, 34, 2, 12, 65 };
            foreach (var item in codeArray)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Press Enter to delete first number of array");
            //Console.ReadLine();
            int[] codeArrayWithoutFirst = new int[codeArray.Length - 1];
            //Index myIndex = 0;
            //Console.WriteLine();
            for (int i = 0; i < codeArray.Length-1; i++)
            {
                codeArrayWithoutFirst[i] = codeArray[i+1];
                Console.WriteLine(codeArrayWithoutFirst[i]);
            }
            
        }
    }
}