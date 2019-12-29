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
        public int places;

        public int CountOrder { get; set; }//number of order the room received
        public HostingUnit()
        {
            HostingUnitKey = Configuration.HostingUnitCount++;
            HostingUnitName = "";
            CountOrder = 0;

        }
        public   override string  ToString()
        {
            return "fsgh";
        }
        public bool IsRoomFree(int EntryDate,int ReleaseDate)
        {
            string beginday = EntryDate.ToString();
            string endday = ReleaseDate.ToString();

            int firstday = Int32.Parse(beginday.Substring(0, 2));
            int firstmonth= Int32.Parse(beginday.Substring(3, 5));
            int lastday= Int32.Parse(endday.Substring(0, 2));
            int lastmonth= Int32.Parse(beginday.Substring(3, 5));
            firstday -= 1;
            firstmonth -= 1;
            lastday -= 1;
            lastmonth -= 1;
            for (int j=firstday,i=firstmonth;j!=lastday || i!=lastmonth;j++)
            {
                if (Diary[i, j])
                    return false;
                if (j == 30) i++;j =-1;
            }

            return true;
        }

    }
