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
        public static long countHostingUnit = 10000000;
        public long HostingUnitKey { get; set; }
        public Host Owner { get; set; }
        public bool[,] Diary = new bool[12, 31];
        public int CountOrder { get; set; }//number of order the room received
        public HostingUnit()
        {
            HostingUnitKey = countHostingUnit++;
            CountOrder = 0;

        }
        public   override string  ToString()
        {
            return "fsgh";
        }

    }
}
