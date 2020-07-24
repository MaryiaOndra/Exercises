using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();

            m.SetMathHandler((msg, result) =>
            { Console.WriteLine("Message: {0}, Result: {1}", msg, result); });

            m.Add(10, 10);

           
            


        }
    }

    public class SimpleMath 
    {
        public delegate void MathMessage(string msg, int result);
        private MathMessage mmDelegate;

        public delegate string VerySimpleDelegate();

        VerySimpleDelegate d = new VerySimpleDelegate(() => {return "Enjoy"; });
        
        public void SetMathHandler(MathMessage target) 
        {
            mmDelegate = target;
        }

        public void Add(int x, int y) 
        {
            mmDelegate?.Invoke("Adding has comleted", x + y);
        }
    }
}
