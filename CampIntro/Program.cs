using System;

namespace CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety = Tip güvenliği
            // Don't repeat yourself = Kendini Tekrarlama
            
            string categoryTag= "Kategori";
            int studentNumber = 32000;
            double yesterdayUSD = 12.313;
            double todayUSD = 12.323;
            bool userLoginCheck = false;


            if (yesterdayUSD>todayUSD)
            {
                Console.WriteLine("--");
            }else if (yesterdayUSD < todayUSD)
            {
                Console.WriteLine("++");
            }
            else
            {
                Console.WriteLine("==");
            }





            if (userLoginCheck)
                 Console.WriteLine("Sisteme giriş yapılmış.");
            else
                Console.WriteLine("Sisteme giriş yapılmamış.");

         
        }
    }
}
