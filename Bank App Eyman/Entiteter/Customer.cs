using Bank_App_Eyman.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App_Eyman.Entiteter
{
    public class Customer : ICustomer
    {
        public string CustomerName { get; set; }
        public int pNr { get; set; }
        public int AllAccounts { get; set; }
        public Customer()
        {
            this.pNr = pNr;
        }
    }
}
