using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        //doit on ajouter { get; set; } au champs hostingUnitKey ?
        public long hostingUnitKey { get; set; }
        public string hostingUnitName { get; set; }
        public Host owner { get; set; }
        public bool[,] diary { get; set; }
        public int adultPlaces { get; set; }
        public int childrenPlaces { get; set; }

        //number of order the room received
        public int countOrder { get; set; }
        public HostingUnit()
        {
            hostingUnitKey = Configuration.hostingUnitCount;
            hostingUnitName = "";
            countOrder = 0;
            diary = new bool[12, 31];
            adultPlaces = 0;
            childrenPlaces = 0;
        }
        public override string ToString()
        {
            return
                "HostingUnitKey : " + hostingUnitKey + "\n" +
                      "HostingUnitName : " + hostingUnitName + "\n" +
                      "Adultplaces : " + adultPlaces + "\n" +
                      "Childrenplaces : " + childrenPlaces + "\n";
        }
        public bool isRoomFree(DateTime entryDate, int numberVacationsDays)
        {

            string beginday = entryDate.ToString();

            int firstDay = Int32.Parse(beginday.Substring(0, 2));
            int firstMonth = Int32.Parse(beginday.Substring(3, 5));

            firstDay -= 1;
            firstMonth -= 1;
            while (numberVacationsDays != 0)
            {
                if (diary[firstMonth, firstDay++])//if one's of the day is already taken 
                    return false;

                if (firstDay == 31) { firstMonth++; firstDay = 0; }//if we got to the end of the month

                numberVacationsDays--;//
            }
            return true;
        }
    }
}
