using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
        public  class BankAccount
    {
        private long BankNumber { get; set; }
        private string BankName { get; set; }
        private long BranchNumber { get; set; }
        private string BranchAddress { get; set; }
        private string BranchCity { get; set; }
        private long BankAccountNumber { get; set; }
        public override string ToString()
        {
            return;
        }
        public BankAccount()
        {

        }
    }
}
