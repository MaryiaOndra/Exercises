using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace FunWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { 12.2, "knife", "fork", "hat", "laptop", 10000000000000000000 };
            arrayList.Add(25);
            arrayList.Add(40);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            bool yes = arrayList.Contains("knife");

            arrayList.Remove(1);
            arrayList.Remove("fork");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            List<string> forbiddenStuff = new List<string> { "badoom", "crazy", "moroover" };
            int index = forbiddenStuff.BinarySearch("crazy");
            bool p = forbiddenStuff.Contains("fork");
            forbiddenStuff.Add("June");

            foreach (string item in forbiddenStuff)
            {
                Console.WriteLine(item);
            }

            Queue<int> vs = new Queue<int> ();
            vs.Enqueue(15);
            vs.Enqueue(105);
            vs.Enqueue(-45);
            vs.Enqueue(50);
            vs.Enqueue(111);
            vs.Enqueue(022);

            int poop = vs.Peek();
            int p2 = vs.Dequeue();

            Console.WriteLine(poop);
            Console.WriteLine(p2);

            foreach (int item in vs)
            {
                Console.WriteLine(item);
            }              

            string exp = "goooo";

            Dictionary<int, string> pairs = new Dictionary<int, string>
            {
                [1] = "Monreal",
                [2] = "Paris",
                [3] = "Praha",
                [5] = "Brest",
                [6] = "Moskow"
            };
            pairs.Add(20, "App");
            foreach (var item in pairs)
            {
                Console.WriteLine($"{pairs.Keys} - {pairs.Values}");
            }
         }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
