using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App_Eyman.Interface
{
    interface ISavingsAccount
    {
        public int Saldo { get; set; }
        public double RänteSats { get; set; }
        public string KontoTyp { get; set; }
        public long KontoNr { get; set; }
    }
}
