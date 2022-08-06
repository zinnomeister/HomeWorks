using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            myArray = new int[10];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;
            myArray[5] = 6;
            myArray[6] = 7;
            myArray[7] = 8;
            myArray[8] = 9;
            myArray[9] = 10;

            //Console.WriteLine(myArray[4]);
            //Console.WriteLine(myArray[6]);
            //Console.WriteLine(myArray[4]);


            //Console.ReadLine();

            //int[] myArray2 = new int[3];
            //myArray2[0] = 10;
            //myArray2[1] = 18;
            //Console.ReadLine();

            //int[] myArray3 = new int[3] { 1, 5, 8 };//input all!!!

            //int[] myArray4 = new int[] { 2, 5, 6, 7, 9, 8 }; //[x]= quantity

            //int[] myArray5 = new[] { 1, 4, 6, 8, 7, 5 };

            //int[] myArray6 = { 1, 4, 5, 7, 8 };

            //int[] myArray7 = Enumerable.Repeat(5, 3).ToArray();//3 of "5"
            
            int[] myArray8= Enumerable.Range(100, 234).ToArray();
            for (int i = 0; i < myArray8.Length; i++)
            {
                Console.WriteLine(myArray8[i]);
            }
            

            Console.ReadLine(); 



        }
    }
}



