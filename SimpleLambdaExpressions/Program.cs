using System;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            TraditionalDelagateSyntax();
            Console.ReadLine();
        }

        static void TraditionalDelagateSyntax() 
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("Here are your even numbers:");

            foreach (int  evenNum in evenNumbers)
            {
                Console.Write("{0}", evenNum);
            }

            Console.WriteLine();        
        }

        static bool IsEvenNumber(int i) 
        {
            return (i % 2).Equals(0);
        }
    }
}
