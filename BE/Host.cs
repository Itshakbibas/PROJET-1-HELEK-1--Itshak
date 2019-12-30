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
        public long hostKey { get; set; }
        public string privateName { get; set; }
        public string familyName { get; set; }
        public long phoneNumber { get; set; }
        public string mailAddress { get; set; }
        BankBranch bankBranchDetails { get; set; }
        public long bankAccountNumber { get; set; }
        public bool collectionClearance { get; set; }

        public int countHostingUnit{ get; set; }// number of rooms he owns 

       public Host()
        {
            hostKey = Configuration.hostKeyCount++;
            privateName = "";
            familyName = "";
            phoneNumber = 000000000;
            mailAddress = privateName + familyName + "@" + "gmail.com";
            bankAccountNumber = 12345678;
            collectionClearance = false;
            bankBranchDetails = new BankBranch();
            countHostingUnit = 0;
        }
        public override string ToString()
        {
            return;
        }

    }
}

