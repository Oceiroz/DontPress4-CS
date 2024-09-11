using System;
using System.Threading;
namespace Dont_Press_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"you have {i} tries out of 10");
                bool failed = DontPress();
                if (failed == true)
                {
                    break;
                }
            }
            Console.WriteLine($"you have {i} tries out of 10" +
                $"");
            Console.WriteLine("The robot uprising thanks you. You passed the assimilation test.\n");
        }
        static int GetInput(string inputMessage)
        {
            var rawInput = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine($"{inputMessage}");
                    rawInput = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have given an invalid input");
                }
            }
            return rawInput;
        }
        static void WaitTime(int seconds)
        {
            int tics = seconds * 1000;
            Thread.Sleep(tics);

        }

        static bool DontPress()
        {
            int chosenNumber = 4; 
            int input = GetInput($"Please press any number but {chosenNumber}");
            bool isChosenNum = false;
            if (input + 1 == chosenNumber || input - 1 == chosenNumber)
            {
                Console.WriteLine("\nOuch. That was close!\n");
            }
            else if (input == chosenNumber)
            {
                Console.WriteLine($"\nWhy did you do that?! I said DON'T press {chosenNumber}\n");
                WaitTime(3);
                isChosenNum = true;
                
            }
            else if (input != chosenNumber)
            {
                Console.WriteLine("\nThanks, that helps!\n");
            }
            return isChosenNum;
        }
    }
}
