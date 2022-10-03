using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İş sınıfları - Business classes
    public class CustomerManager
    {
        
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi!!! Müşteri No: {0}", customer.CustomerNumber);
        }
    }
}
