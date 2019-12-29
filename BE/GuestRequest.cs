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
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        //area
        public TypeAreaOfTheCountry Area { get; set; }
        //subArea
        //type hostingUnit
        public TypeOfHostingUnit Type { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Options Pool { get; set; }
        public Options Jacuzzi { get; set; }
        public Options Garden { get; set; }
        public Options ChildrensAttractions { get; set; }
        public GuestRequest()
        {
            PrivateName = "";
            FamilyName = "";
            MailAddress = "";
            Status = CustomerRequirementStatus.active;

        }
        public override string ToString() { return ""; }

    }
}
