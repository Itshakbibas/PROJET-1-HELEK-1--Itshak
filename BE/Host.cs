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

        public Host(string privateName, string familyName, long phoneNumber,
                    string suffix, string bankAccount)
        {
            HostKey = countHost++;
            PrivateName = privateName;
            FamilyName = familyName;
            PhoneNumber = phoneNumber;
            MailAddress = privateName + "." + familyName + "@" + suffix;
            BankAccount = bankAccount;
        }
        public override string ToString()
        {
            return;
        }

    }
}

