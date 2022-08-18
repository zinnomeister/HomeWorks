using System;

using System.Linq;// ???

namespace CharArray
{
    class Program

    {
        static void Main(string[] args)
        {
            TaskOne();
            Console.Clear();
            TaskTwo();
            Console.Clear();
            TaskThree();

        }
        static void TaskOne()
        {
            string startSentence = "I`m doing my   homework Right now.Please, Don't    disturb me!!! 12345 ";
            Console.WriteLine($"Start Sentence is:\n{startSentence}");

            for (int i = 1; i < startSentence.Length; i++)
            {
                startSentence = startSentence.ToLower();
            }
            startSentence = startSentence.Replace(".", ". ");

            startSentence = startSentence.Replace("i`m", "I'm");

            startSentence = startSentence.Replace("please", "Please");


            while (startSentence.Contains("!!"))
            {
                startSentence = startSentence.Replace("!!", "!");
            }

            while (startSentence.Contains("  "))
            {
                startSentence = startSentence.Replace("  ", " ");
            }

            char[] charSentence = startSentence.ToCharArray();

            char[] charWithoutNumbers = Array.FindAll(charSentence, (n => !Char.IsDigit(n)));

            Console.WriteLine("\nThe sentence after correction:");
            Console.WriteLine(charWithoutNumbers);

            Console.ReadLine();


        }
        static void TaskTwo()
        {
            string textWithSpaces = "London is the capital of Great Britain";
            string[] byWordsArray = textWithSpaces.Split(' ');
            Console.WriteLine("Quantity of words:\t" + (byWordsArray.Length));
            Console.ReadLine();

        }
        static void TaskThree()
        {
            foreach (string line in File.ReadAllLines(@"C:\Users\zinno\OneDrive\Разработка\HomeWorks\Task3-HW2.txt"))
                Console.WriteLine(line);

            Console.ReadLine();
        }
    }
}
//static void TaskTwo()
//static void TaskThree()

