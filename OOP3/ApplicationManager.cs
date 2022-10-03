using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class ApplicationManager
    {
        private ICreditManager _creditManager;
        private ILoggerService _loggerService;

        public ApplicationManager(ICreditManager creditManager, ILoggerService loggerService)
        {
            _creditManager = creditManager;
            _loggerService = loggerService; 
        }

        public void MakeApplication()
        {
            //Code 
            //Code

            _creditManager.Calculate();
            _loggerService.Log();
        }

        public void CreditPreview(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
