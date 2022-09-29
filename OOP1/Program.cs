using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 2,
                Name = "Ahşap Oyma Çalışma Masası",
                Description = "",
                UnitsInStock = 12,
                UnitPrice = 400
            };

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Raspberry Pi 4",
                Description = "",
                UnitsInStock = 5,
                UnitPrice = 1200
            };

            Product product3 = new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Gamebooster Firestrom Klavye RGB ",
                Description = "",
                UnitsInStock = 80,
                UnitPrice = 300
            };

            //PascalCase  -  camelCase
            //case sensitive - büyük küçük harf duyarlı
            //
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool,char... değer tip
            //array, class, abstract class, interface... referans tip
            //ref, out

        }
    }
}
