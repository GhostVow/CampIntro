using System;

namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;

            number1 = number2;
            number2 = 34;

            Console.WriteLine(number1);

            int[] numbers1 = { 10, 20, 30, 40};
            int[] numbers2 = { 100, 200, 300, 400 };

            numbers1 = numbers2;
            numbers2[0] = 4;

            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers1[0]);
        }
    }
}
