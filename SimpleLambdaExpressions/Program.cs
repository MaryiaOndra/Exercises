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

            Console.WriteLine();

            AnonymousMethodSynta();

            Console.WriteLine();

            LambdaExpressionSyntax();

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

        static void AnonymousMethodSynta()
        {
            List<int> list = new List<int>();

            list.AddRange(new int[] { 20, 1, 5, 879, 54, 21, 3, 4 });

            List<int> evenNumbers = list.FindAll(delegate (int i)
            { return (i % 2) == 0; });

            Console.WriteLine("Here are your even numbers:");

            foreach (int evenNum in evenNumbers)
            {
                Console.WriteLine("{0}\t", evenNum);
            }

            Console.WriteLine();
        }

        static void LambdaExpressionSyntax() 
        {
            List<int> list = new List<int>();

            list.AddRange(new int[] {2, 50, 87, 231, 54, 21321, 54654, 8748, 46 });

            List<int> evenNumbers = list.FindAll((i) =>
             {
                 Console.WriteLine("value of i is currently: {0}", i);
                 bool isEven = ((i % 2).Equals(0));
                 return isEven;
             });

            Console.WriteLine("Here are your even numbers:");

            foreach (int evenNum in evenNumbers)
            {
                Console.WriteLine("{0} is even\t", evenNum);
            }
            Console.WriteLine();
        }
    }

}
