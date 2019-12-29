using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        public static long countHost = 10000000;
        public long HostKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        BankBranch BankBranchDetails { get; set; }
        public long BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }

        public int CountHostingUnit{ get; set; }// number of rooms he owns 

       public Host()
        {
            HostKey = countHost++;
            PrivateName = "";
            FamilyName = "";
            PhoneNumber = 00000000;
            MailAddress = PrivateName + FamilyName + "@" + "gmail.com";
            BankAccountNumber = 12345678;
            CollectionClearance = false;
            BankBranchDetails = new BankBranch();
            CountHostingUnit = 0;
        }
        public override string ToString()
        {
            return;
        }

    }
}

