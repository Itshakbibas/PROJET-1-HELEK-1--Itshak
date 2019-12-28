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
        public HostingUnit()
        {
            HostingUnitKey = countHostingUnit++;
            

        }
        public   override string  ToString()
        {
            return "fsgh";
        }

    }
}
