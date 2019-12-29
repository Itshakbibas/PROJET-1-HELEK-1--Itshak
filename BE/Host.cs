using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host

    {
        List<string> PN = new List<string>() { "mickael", "itshak", "shmuel","Acher","raphael","Elie",
            "Dov" };
        List<string> FN = new List<string>() { "Balensi", "bibas", "Illouz", "Klein", "Bloch", "Drai", "Chriqui" };
        Random r = new Random(DateTime.Now.Millisecond);
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
            HostKey = Configuration.HostKeyCount++;
            PrivateName = "";
            FamilyName = "";
            PhoneNumber = 000000000;
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

