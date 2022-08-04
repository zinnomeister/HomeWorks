using System;
namespace Help
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mas = new int[10];
            //int i = 0;
            //string test;
            //int count = 0;

            //do
            //{
            //    test = Console.ReadLine();
            //    if (test == "end") break;
            //    mas[i] = Convert.ToInt32(test);
            //    ++i; ++count;
            //} while (true);

            //Console.WriteLine("Vivod: ");
            //for (int j = 0; j < count; j++)
            //{
            //    Console.Write("{0} ", mas[j]);
            //}
            //Console.ReadLine

            //string sentence = "Mahesh Chand";  
            //char[] charArr = sentence.ToCharArray();
            //foreach (char ch in charArr)
            //{
            //    Console.WriteLine(ch);
            //}


            //Console.WriteLine("Введите размер массива");
            //int n = int.Parse(Console.ReadLine());
            //string[] arr = new string[n];
            //Console.WriteLine("Вводите элементы массива массива нажимая Enter");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Console.ReadLine(); // заполнение массива
            //}
            //Console.WriteLine("Массив: ");
            //foreach (string s in arr) Console.Write(s + " "); // вывод массива
            //Console.ReadLine();

            string a;
            int[] b = new int[100];
            int i = 0;

            while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
                b[i++] = Convert.ToInt32(a); //в стркое нет "конца" - значит конвертим и пишем в массив

            for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
                Console.WriteLine(b[k]);

            Console.ReadKey(true);
        }
    }
}