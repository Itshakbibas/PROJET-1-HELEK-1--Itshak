using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    //changement nom en minuscule
    public class GuestRequest
    {

        public long guestRequestKey { get; set; }
        public string privateName { get; set; }
        public string familyName { get; set; }
        public string mailAddress { get; set; }
        //status


        //faut il definir le satut de CustomerRequirementStatus 
        //dans le champs directement plutot que ds le ctor
        //car interdit d'utiliser ctor d'apres ennoncé

        public CustomerRequirementStatus status { get; set; }
        public DateTime registrationDate { get; set; }
        public DateTime entryDate { get; set; }
        public DateTime releaseDate { get; set; }
        //area
        public TypeAreaOfTheCountry area { get; set; }
        //subArea

        public TypeOfHostingUnit type { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public Options pool { get; set; }
        public Options jacuzzi { get; set; }
        public Options garden { get; set; }
        public Options childrensAttractions { get; set; }
        public GuestRequest()
        {

            guestRequestKey = Configuration.guestRequestCount++;
            privateName = "";
            familyName = "";
            mailAddress = "";
            status = CustomerRequirementStatus.active;
            registrationDate = new DateTime(2000,1,1);
            entryDate = new DateTime(2000, 1, 1);
            releaseDate= new DateTime(2000, 1, 1);
            area = TypeAreaOfTheCountry.all;
            type = TypeOfHostingUnit.all;
            adults = 1;
            children = 0;
            pool = Options.optional;
            garden = Options.optional;
            childrensAttractions = Options.optional;

        }
        public override string ToString() { 
            return string.Format(""); 
        }


    }
}
