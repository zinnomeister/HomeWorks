using System;
namespace TwoDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            PartOne();
            Console.Clear();
            PartTwo();
            Console.Clear();
            PartThree();
            Console.Clear();
            PartFour();
        }
        static void PartOne()
        {


            int[,] ArrayTwoDim1 = new int[3, 5]
            {
            { 34, 34,56,123,65},
            { 34,67,789,23,56},
            {324,56,24,45,7 }
            };

            int[,] ArrayTwoDim2 = new int[,]
                {
                {23,45,23,34 },
                { 45,67,987,5},
                {34,56,89,456 },
                { 354,98,76,80},
                };
            int[,] ArrayTwoDim3 =
                {
            { 45,67,34,57,877,32},
            { 34,78,6,24,46,46},
            { 234,567,45,4,234,67}
            };

            foreach (var itemFirst in ArrayTwoDim1)
            {
                Console.Write(itemFirst + " ");

            }
            Console.WriteLine();

            int height2 = ArrayTwoDim2.GetLength(0);
            int width2 = ArrayTwoDim2.GetLength(1);

            for (int y = 0; y < height2; y++)
            {
                for (int x = 0; x < width2; x++)
                {
                    Console.Write(ArrayTwoDim2[y, x] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        static void PartTwo()
        {
            int[,] ArrayRandom = new int[10, 6];

            Random randomNumbers = new Random();

            for (int y = 0; y < ArrayRandom.GetLength(0); y++)
            {
                for (int x = 0; x < ArrayRandom.GetLength(1); x++)
                {
                    ArrayRandom[y, x] = randomNumbers.Next(25,55);
                }
                Console.WriteLine();
            }

            for (int y = 0; y < ArrayRandom.GetLength(0); y++)
            {
                for (int x = 0; x < ArrayRandom.GetLength(1); x++)
                {
                    Console.Write(ArrayRandom[y,x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void PartThree()
        {
            int[,] ArrayFromKeyboard = new int[5, 4];


            for (int y = 0; y < ArrayFromKeyboard.GetLength(0); y++)
            {
                for (int x = 0; x < ArrayFromKeyboard.GetLength(1); x++)
                {
                    Console.WriteLine("Y: " + y + "X: " + x);
                    ArrayFromKeyboard[y, x] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int y = 0; y < ArrayFromKeyboard.GetLength(0); y++)
            {
                for (int x = 0; x < ArrayFromKeyboard.GetLength(1); x++)
                {
                    Console.Write(ArrayFromKeyboard[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void PartFour()
        {
            string[,] ArrayStringFromKeyboard = new string[3, 4];


            for (int y = 0; y < ArrayStringFromKeyboard.GetLength(0); y++)
            {
                for (int x = 0; x < ArrayStringFromKeyboard.GetLength(1); x++)
                {
                    Console.WriteLine("Y: " + y + "X: " + x);
                    ArrayStringFromKeyboard[y, x] = Console.ReadLine();
                }
                Console.WriteLine();
            }

            for (int y = 0; y < ArrayStringFromKeyboard.GetLength(0); y++)
            {
                for (int x = 0; x < ArrayStringFromKeyboard.GetLength(1); x++)
                {
                    Console.Write(ArrayStringFromKeyboard[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}



