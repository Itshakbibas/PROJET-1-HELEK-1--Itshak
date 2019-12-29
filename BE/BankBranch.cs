using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
        public  class BankBranch
    {
        public Bank BankNumber { get; set; }
        public string BankName { get; set; }
        public int BranchNumber { get; set; }
        public string BranchAddress { get; set; }
        public string BranchCity { get; set; }

        public BankBranch(){
            BankNumber = Bank.bankHapoalim;
            BankName = Bank.bankHapoalim.ToString();
            BranchNumber = 0;
            BranchAddress = "";
            BranchCity = "";
        }

        public override string ToString()
        {
            return "";
        }
    }
}
