using System;
using System.Collections.Generic;

namespace MyDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Tasneem");
            dictionary.Add(2, "Celine");
            dictionary.Add(3, "Bana");
            dictionary.Add(4, "Yser");

            

            Console.WriteLine("1");

        }
        
    }
}
