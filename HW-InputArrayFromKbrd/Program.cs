﻿using System;

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

            Console.WriteLine("\nOutput of Array:");

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

            Console.WriteLine("\nOutput of Array in reverse mode:");

            for (int i = Array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Array[i]);
            }

            Console.ReadLine();



        }
    }
}



