using System;

using System.Linq;// ???

namespace Array
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Input sentence:\t");
            string str = Console.ReadLine();

            Console.WriteLine(str);
            foreach (var item in str)
            {
                Console.WriteLine($"{item}");
            }
            //Console.ReadLine();

            Console.Write("Input symbols:\t");
            string str2 = Console.ReadLine();
            Console.WriteLine(str2);


        }
    }
}
