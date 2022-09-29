using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("dwadwa");
            Console.WriteLine(myList[0]);
            myList.Add("daweca");
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);

            

            List<string> myList2 = new List<string>(1);
            myList2.Add("dwadwa");
            myList2.Add("as");
            myList2.Add("ss");
            myList2.Add("dd");
            myList2.Add("cc");
            myList2.Add("kk");
            myList2.Add("bb");
            myList2.Add("aax");
            myList2.Add("dddf");
            Console.WriteLine(myList2.Capacity);
            Console.WriteLine(myList2[2]);

            myList2.Remove("ss");

            Console.WriteLine(myList2.Count);
            Console.WriteLine(myList2[2]);
            
        }
    }
}
