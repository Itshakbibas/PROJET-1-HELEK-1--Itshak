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
        public override  string ToString()
        {
            return"gsgs";
        }
        public Order()
        {
            GuestRequestKey=10000001;
            Status = StatusOfOrder.NotYetAddressed;
        }
        public Order (Order order)
        {

        }
    }
}
