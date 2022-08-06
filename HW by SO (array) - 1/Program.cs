using System;

using System.Linq;// ???

namespace Homework
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Input sentence:\t");
            string str = Console.ReadLine();
            foreach (var item in str)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("Press any key for swith to the next task");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Task 1.2:\n");

            char[] charArray = new[] { 'Z', 'i', 'n', 'n', 'o' };
            string charString = new string(charArray);
            Console.WriteLine(charString);
            Console.WriteLine("Chars to string: {0}", charString);

            Console.WriteLine("Press any key for swith to the next task");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Task 2:\n");
            Console.WriteLine("Input start number in sequence:\t");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input quantity of numbers in sequence:\t");
            int quantityOfNumber = int.Parse(Console.ReadLine());
            int[] intArray = Enumerable.Range(startNumber, quantityOfNumber).ToArray();
            Console.WriteLine("Input number which you want find to:\t");
            int findNumber = int.Parse(Console.ReadLine());
            int result = Array.Find(intArray, i => i == findNumber);

            if (result == findNumber)
                Console.WriteLine("There is asking number in this array: " + findNumber);
            else
                Console.WriteLine("There is no " + findNumber + " in this Array");

            Console.WriteLine("Press any key for swith to the next task");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Task 3:\n");
            int[] codeArray = new[] { 12, 65, 3, 67, 568, 395, 34, 2, 12, 65 };
            Console.WriteLine("Your array:\n");

            foreach (var item in codeArray)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("Input number from array to delete:\n");
            int deleteNumber = int.Parse(Console.ReadLine());
            int[] clearArray = codeArray.Where(i => i != deleteNumber).ToArray();
            Console.WriteLine("New array without " + deleteNumber + ":\n");
            foreach (var item in clearArray)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
            Console.WriteLine("Press any key for swith to the next part of task");

            Console.Clear();
            Console.WriteLine("Your array:\n");

            foreach (var item in codeArray)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Press Enter to clear the array");
            Console.ReadLine();
            //с очисткой не понял, везде нахожу, что массив сохраняет свою длину всю жизнь.
            //Я так понимаю, что должен быть какой-то метод Clear(void Clear),
            //но не понял, что с ним делать
            //Потому поменял на нули вручную

            for (int i = 0; i < codeArray.Length; i++)
            {
                codeArray[i] = 0;
                Console.WriteLine(codeArray[i]);
            }
           
            Console.WriteLine("Press any key for swith to the next part of task");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your array:\n");
            codeArray = new[] { 12, 65, 3, 67, 568, 395, 34, 2, 12, 65 };
            foreach (var item in codeArray)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Press Enter to delete first number of array");
            Console.ReadLine();
            int[] codeArrayWithoutFirst = new int[codeArray.Length - 1];
          
            for (int i = 0; i < codeArray.Length-1; i++)
            {
                codeArrayWithoutFirst[i] = codeArray[i+1];
                Console.WriteLine(codeArrayWithoutFirst[i]);
            }

            Console.WriteLine("Press any key for swith to the next part of task");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your array:\n");
            codeArray = new[] { 12, 65, 3, 67, 568, 395, 34, 2, 12, 65 };
            foreach (var item in codeArray)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Press Enter to delete last number of array");
            Console.ReadLine();
            int[] codeArrayWithoutLast = new int[codeArray.Length - 1];

            for (int i = 0; i < codeArray.Length - 1; i++)
            {
                codeArrayWithoutLast[i] = codeArray[i];
                Console.WriteLine(codeArrayWithoutLast[i]);
            }
            Console.WriteLine("The end of the task");

            Console.ReadLine();
        }
    }
}
