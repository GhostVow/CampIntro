using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                ProductName = "Elma",
                Price = 4.54,
                Description = "Amasya Elması",
                Stock = 30,
            };

            Product product2 = new Product
            {
                Id = 2,
                ProductName = "Armut",
                Price = 8.14,
                Description = "Bursa Armutu",
                Stock = 24,
            };

            Product product3 = new Product
            {
                Id = 3,
                ProductName = "Karpuz",
                Price = 4,
                Description = "Diyarbakır Karpuzu",
                Stock = 100,
            };

            Product[] products = { product1, product2, product3 };

            //type safe - tip güvenli
            
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductName}: {product.Price}Tl");
            }

            
            Console.WriteLine("--------------Methods-------------------");

            //instance - örnek
            //encapsulation
            CartManager cartManager = new CartManager();
            
            cartManager.Add(product3);

        }
    }
}
//Don't repeat yourself - DRY - Clean Code - Best Practice
//Pascal Case - Method And Class Name