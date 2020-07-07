using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithStatic
{
    static class TimeUtilClass
    {
        public static void PrintTime() 
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate() 
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }
}
