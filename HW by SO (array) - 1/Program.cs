using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTaskPartOne();
            FirstTaskPartTwo();
            Console.Clear();

            SecondTask();
            Console.Clear();

            ThirdTask();
            Console.ReadLine();
        }

        static void FirstTaskPartOne()
        {
            Console.Write("Input sentence:\t");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();

            Console.WriteLine(string.Join(",", charArray));
            //foreach (var item in charArray)
            //    Console.WriteLine($"{item}");

            Console.WriteLine("Press any key for swith to the next task");
            Console.ReadLine();

            Console.Clear();
        }
        static void FirstTaskPartTwo()
        {
            Console.WriteLine("Task 1.2:\n");

            char[] charArray = { 'Z', 'i', 'n', 'n', 'o' };
            string charString = new string(charArray);
            Console.WriteLine(charString);
            Console.WriteLine("Chars to string: {0}", charString);

            Console.WriteLine("Press any key for swith to the next task");
            Console.ReadLine();
        }

        static void SecondTask()
        {

        SecondTaskLabel:
            try
            {
            
                Console.ResetColor();

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
                    Console.WriteLine($"There is asking number in this array: {findNumber}");
                else
                    Console.WriteLine("There is no " + findNumber + " in this Array");

                Console.WriteLine("Press any key for swith to the next task");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
                goto SecondTaskLabel;
            }
        }

        static void ThirdTask()
        {
            Console.WriteLine("Task 3:\n");

            int[] codeArray = new[] { 12, 65, 3, 67, 568, 395, 34, 2, 12, 65 };
            Console.WriteLine("Your array:\n");

            Console.WriteLine(string.Join("/", codeArray));
            //foreach (var item in codeArray)
            //{
            //    Console.WriteLine($"{item}");
            //}

            Console.WriteLine("Input number from array to delete:\n");
            int numberToDelete = int.Parse(Console.ReadLine());
            int[] clearArray = codeArray.Where(i => i != numberToDelete).ToArray();
            Console.WriteLine($"New array without {numberToDelete}:\n");

            Console.WriteLine(string.Join("/", clearArray));

            //foreach (var item in clearArray)
            //{
            //    Console.WriteLine($"{item}");
            //}

            Console.ReadLine();
            Console.WriteLine("Press any key for switch to the next part of task");

            Console.Clear();
            Console.WriteLine("Your array:\n");

            Console.WriteLine(string.Join("/", codeArray));
            //foreach (var item in codeArray)
            //{
            //    Console.WriteLine($"{item}");
            //}
            Console.WriteLine("Press Enter to clear the array");
            Console.ReadLine();
            //с очисткой не понял, везде нахожу, что массив сохраняет свою длину всю жизнь.
            //Я так понимаю, что должен быть какой-то метод Clear(void Clear),
            //но не понял, что с ним делать
            //Потому поменял на нули вручную

            //for (int i = 0; i < codeArray.Length; i++)
            //{
            //    codeArray[i] = 0;
            //    Console.WriteLine(codeArray[i]);
            //}

            Array.Clear(codeArray);


            Console.WriteLine("Press any key for swith to the next part of task");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your array:\n");
            codeArray = new[] { 12, 65, 3, 67, 568, 395, 34, 2, 12, 65 };
            Console.WriteLine(string.Join("/", codeArray));

            Console.WriteLine("Press Enter to delete first number of array");
            Console.ReadLine();

            codeArray = codeArray.Skip(1).ToArray();

            Console.WriteLine("Press any key for swith to the next part of task");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your array:\n");
            codeArray = new[] { 12, 65, 3, 67, 568, 395, 34, 2, 12, 65 };

            string joined = string.Join("/", codeArray);
            Console.WriteLine(joined);

            //foreach (var item in codeArray)
            //{
            //    Console.WriteLine($"{item}");
            //}
            Console.WriteLine("Press Enter to delete last number of array");
            Console.ReadLine();

            //codeArray = codeArray.ToList().FindAll(r => r == codeArray.Last()).ToArray();
            codeArray = codeArray.Skip(codeArray.Length - 1).ToArray();

            Console.WriteLine("The end of the task");
        }
    }
}
