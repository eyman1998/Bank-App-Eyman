using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App_Eyman.Entiteter
{
       public class BankLogic
    {
        // Banklogic
        public List<Customer> customers { get; set; } 
        public List<SavingsAccount> savingsaccounts { get; set; }
        public BankLogic()
        {
            customers = new List<Customer>();
            savingsaccounts = new List<SavingsAccount>();
        }



    }
}
