using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            //return color
            Console.ForegroundColor = previous;
        }

        static int Add(int x, int y) 
        {
            return y + x;
        }
        static string SumTostring(int x, int y) 
        {
            return (x + y).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");

            //use Action<> for showing DisplayMessage
            Action<string, ConsoleColor, int> actionTarget =
                new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            Console.ReadLine();

            //call Func methods

            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = SumTostring;
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
