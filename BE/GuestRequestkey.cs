using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        public static long GuestRequestKey = 10000001;
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        //status
        public CustomerRequirementStatus Status { get; set; }
        public DateTime RegistrationDate = new DateTime();
        public DateTime EntryDate = new DateTime();
        public DateTime ReleaseDate = new DateTime();
        //area
        public TypeAreaOfTheCountry Area;
        //subArea
        //type hostingUnit
        public TypeOfHostingUnit Type { get; set; }
        public int Adults;
        public int Children;
        public Options Pool;
        public Options Jacuzzi;
        public Options Garden;
        public Options ChildrensAttractions;
        public override ToString();

    }
}
