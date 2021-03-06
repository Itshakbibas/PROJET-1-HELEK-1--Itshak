﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host : Clonable

    {
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
            hostKey = Configuration.hostKeyCount;
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
            return "hostKey : " + hostKey + "\n" +
                "privateName : " + privateName + "\n" +
                "familyName : " + familyName + "\n" +
                " phoneNumber : " + phoneNumber + "\n" +
                "mailAddress : " + mailAddress + "\n" +
                "bankAccountNumber : " + bankAccountNumber + "\n" +
                "collectionClearance : " + collectionClearance + "\n" +
                "bankBranchDetails : " + bankBranchDetails + "\n" +
                "countHostingUnit : " + countHostingUnit;
        }

    }
}

