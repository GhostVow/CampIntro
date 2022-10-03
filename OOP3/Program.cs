using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICreditManager creditManager = new HousingCreditManager();
            
            ApplicationManager applicationManager = new ApplicationManager(creditManager, new FileLoggerService());

            applicationManager.MakeApplication();

            List<ICreditManager> creditList = new List<ICreditManager>() { new ConsumerCreditManager(), new VehicleCreditManager()};

            applicationManager.CreditPreview(creditList);

        }
    }
}
