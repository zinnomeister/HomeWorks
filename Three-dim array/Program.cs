using System;

namespace ThreeDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            HardInputThreeDimArray();
            Console.Clear();
            RandomThreeDimArray();
            Console.Clear();
            RandomDimRandomArray();
        }
        static void HardInputThreeDimArray()
        {


            int[,,] hardInputThreeDimArray =
            {
                {
                { 45,5,23,56},
                {34,67,34,567 },
                },

                {
                { 67,67,35,2},
                { 0,76,3,7}
                },

                {
                {67,8978,34,2 },
                { 45,987,57,45}
                }
            };

            for (int i = 0; i < hardInputThreeDimArray.GetLength(0); i++)
            {
                Console.WriteLine("\n\tPage # " + (i + 1) + "\n");
                for (int j = 0; j < hardInputThreeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < hardInputThreeDimArray.GetLength(2); k++)
                    {
                        Console.Write("\t" + hardInputThreeDimArray[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n---------------------------------------------------------------------");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void RandomThreeDimArray()
        {
            Random random = new Random();
            int[,,] randomThreeDimArray = new int[4, 3, 6];
            for (int i = 0; i < randomThreeDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomThreeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < randomThreeDimArray.GetLength(2); k++)
                    {
                        randomThreeDimArray[i, j, k] = random.Next(0, 99);
                    }
                }
            }

            for (int i = 0; i < randomThreeDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomThreeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < randomThreeDimArray.GetLength(2); k++)
                    {
                        Console.Write(randomThreeDimArray[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void RandomDimRandomArray()
        {
            Random random = new Random();

            int[][][] randomDimRandomArray = new int[random.Next(3, 6)][][];
            for (int i = 0; i < randomDimRandomArray.Length; i++)
            {
                randomDimRandomArray[i] = new int[random.Next(2, 5)][];
                for (int j = 0; j < randomDimRandomArray[i].Length; j++)
                {
                    randomDimRandomArray[i][j] = new int[random.Next(3, 5)];
                    for (int k = 0; k < randomDimRandomArray[i][j].Length; k++)
                    {
                        randomDimRandomArray[i][j][k] = random.Next(99);
                    }
                }
            }

            for (int i = 0; i < randomDimRandomArray.Length; i++)
            {
                Console.WriteLine("Page # " + (i + 1) + "\n");
                for (int j = 0; j < randomDimRandomArray[i].Length; j++)
                {
                    for (int k = 0; k < randomDimRandomArray[i][j].Length; k++)
                    {
                        Console.Write(randomDimRandomArray[i][j][k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}