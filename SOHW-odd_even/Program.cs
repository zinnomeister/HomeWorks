using System;

namespace HW020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW by Sergei Oligarkhovich - odd/even");

            //double oddCount = 0; //нечётные
            // evenCount = 0; //чётные


            Console.WriteLine("Input starting value");
            double currentValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Input ending value");
            double limit = double.Parse(Console.ReadLine());

        Case:
            Console.WriteLine("Input your choice");
            Console.WriteLine("If you want to see odd numbers - press '1'");
            Console.WriteLine("If you want to see even numbers - press '2'");

            double choice = double.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    while (currentValue <= limit)
                    {
                        if (currentValue % 2 != 0)
                        {
                            Console.WriteLine(currentValue + ";");
                            currentValue++;
                            //evenSum += currentValue;
                        }
                        else
                        {
                            currentValue++;

                        }
                        //currentValue++;
                    }
                    break;

                case 2:

                    while (currentValue <= limit)
                    {
                        if (currentValue % 2 == 0)
                        {
                            Console.WriteLine(currentValue + ";");
                            currentValue++;
                            //evenSum += currentValue;
                        }
                        else
                        {
                            currentValue++;

                        }
                        //currentValue++;

                    }
                    break;
                default:
                    Console.WriteLine("Wrong choice! Try again");
                    goto Case;
                    break;

                //Console.WriteLine("Quantity of odds: " + oddCount);
                //Console.WriteLine("Quantity of evens: " + evenCount);
                //Console.WriteLine("Sum of odds: " + oddSum);
                //Console.WriteLine("Sum of evens: " + evenSum);
                //Exit:
                    Console.ReadLine();
            }
        }
    }
}