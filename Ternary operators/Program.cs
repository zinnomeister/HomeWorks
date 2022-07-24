using System;

namespace TernaryOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int InputData = int.Parse(Console.ReadLine());

            int OutputData = InputData <= 0 ? 0 : InputData;
            Console.WriteLine(OutputData);
            Console.ReadLine();
        }
    }
}



