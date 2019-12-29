using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {

        public long HostingUnitKey { get; set; }
        public long GuestRequestKey { get; set; }
        public long OrderKey { get; set; }
        public StatusOfOrder Status;
        public DateTime createDate { get; set; }
        public DateTime OrderDate { get; set; } 
       



        public Order()
        {
            hostingUnitKey = 00000000;
            guestRequestKey = 00000000;
            orderKey = 00000000;
            status = StatusOfOrder.notYetAddressed;
            createDate = new DateTime(2000, 1, 1);
            orderDate = new DateTime(2000, 1, 1);
        }
        public override string ToString()
        {
            return "";
        }
    }
}
