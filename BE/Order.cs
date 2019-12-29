﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        public long hostingUnitKey { get; set; }
        public long guestRequestKey { get; set; }
        public long orderKey { get; set; }
        public StatusOfOrder status;
        public DateTime createDate { get; set; }
        public DateTime orderDate { get; set; }

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
