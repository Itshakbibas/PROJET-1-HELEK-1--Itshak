using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        public long GuestRequestKey ;
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        //status

        //faut il definir le satut de CustomerRequirementStatus 
        //dans le champs directement plutot que ds le ctor
        //car interdit d'utiliser ctor d'apres ennoncé
        public CustomerRequirementStatus Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        //area
        public TypeAreaOfTheCountry Area { get; set; }
        //subArea
        public TypeOfHostingUnit Type { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Options Pool { get; set; }
        public Options Jacuzzi { get; set; }
        public Options Garden { get; set; }
        public Options ChildrensAttractions { get; set; }
        public GuestRequest()
        {
            GuestRequestKey = Configuration.GuestRequestCount++;
            PrivateName = "";
            FamilyName = "";
            MailAddress = "";
            Status = CustomerRequirementStatus.active;
            RegistrationDate = new DateTime(2000,1,1);
            EntryDate = new DateTime(2000, 1, 1);
            ReleaseDate= new DateTime(2000, 1, 1);
            Area = TypeAreaOfTheCountry.all;
            Type = TypeOfHostingUnit.all;
            Adults = 1;
            Children = 0;
            Pool = Options.optional;
            Garden = Options.optional;
            ChildrensAttractions = Options.optional;

        }
        public override string ToString() { 
            return string.Format(""); 
        }

    }
}
