using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Add!!! \nProduct Name: {0}", product.Name);
        }



        public void Delete()
        {
           
        }

        public void Update(Product product)
        {
            Console.WriteLine("Update!!! \nProduct Name: {0}", product.Name);
        }

        public int Sum(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }



    }
}
