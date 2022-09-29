using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
        
            names.Add("Hakan");

            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);



        }
    }
}
