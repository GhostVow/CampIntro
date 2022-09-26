using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] courseList = { "Yazılım Geliştirme Kampı C#", "Java Kampı", "Javascript Kampı" };

            

            for (int i = 0; i < courseList.Length; i++)
            {
                Console.WriteLine(courseList[i]);
            }

            foreach (var item in courseList)
            {
                Console.WriteLine(item);

            }

        }
    }

    
}
