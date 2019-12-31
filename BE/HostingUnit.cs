using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        /*test git*/
       
        public  long HostingUnitKey;
        public string HostingUnitName { get; set; }
        public Host Owner { get; set; }
        public bool[,] Diary = new bool[12, 31];
        public int Adultplaces;
        public int Childrenplaces;
        public int CountOrder { get; set; }//number of order the room received
        public HostingUnit()
        {
            HostingUnitKey = Configuration.HostingUnitCount;
            HostingUnitName = "";
            CountOrder = 0;

        }
        public   override string  ToString()
        {
            return    "HostingUnitKey : " + HostingUnitKey + "\n" +
                      "HostingUnitName : " + HostingUnitName + "\n" +
                      "Adultplaces : "  + Adultplaces + "\n" +
                      "Childrenplaces : " + Childrenplaces + "\n";        }
        public bool isRoomFree(DateTime entryDate,int numberVacationsDays)
        {
           
            string beginday = entryDate.ToString();

            int firstDay = Int32.Parse(beginday.Substring(0, 2));
            int firstMonth= Int32.Parse(beginday.Substring(3, 5));
           
            firstDay -= 1;
            firstMonth -= 1;
            while(numberVacationsDays != 0)
            {
                if (Diary[firstMonth, firstDay++])//if one's of the day is already taken 
                    return false;

                if (firstDay == 31) { firstMonth++; firstDay = 0; }//if we got to the end of the month
               
                numberVacationsDays--;//
            }


            return true;
        }


    }
