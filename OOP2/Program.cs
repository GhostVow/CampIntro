using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.FirstName = "Hakan";
            customer1.LastName = "Türkoğlu";
            customer1.NationalityId = "2231112333";
            customer1.CustomerNumber = "123431123344";


            Customer customer2 = new CorporateCustomer
            {
                Id = 2,
                CustomerNumber = "312334441123",
                CompanyName = "TDGC Company",
                TaxNumber = "1233455321"
            };

            //Gerçek Müşteri - Tüzel Müşteri
            
            CustomerManager customerManager = new CustomerManager();
            
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
