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
            //TaskTwo();
            //Console.Clear();
            //TaskThree();
            //Console.Clear();

            Console.ReadLine();
        }
        static void TaskOne()
        {
            string startSentence = "I`m doing my   homework Right now.Please, Don't    disturb me!!! 12345 ";
            while (startSentence.Contains("  "))
            {
                startSentence = startSentence.Replace("  ", " ");
            }
            
            Console.WriteLine(startSentence);

            char[] charSentence = startSentence.ToCharArray();

            char[] charWithoutNumbers = Array.FindAll(charSentence, (n => !Char.IsDigit(n)));

            Console.WriteLine(charWithoutNumbers);

            
            Console.ReadLine();


        }

        //Console.ReadLine();
    }
}
//static void TaskTwo()
//static void TaskThree()

