using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        public static List<HostingUnit> hostingUnitList { get; set; }
        public static List<GuestRequest> guestRequestList { get; set; }
        public static List<Order> orderList { get; set; }

        public DataSource()
        {

            /*string[] privateName = new string[] { "mickael", "itshak", "chmoulik", "hillel", "acher" };
            string[] familyName = new string[] { "balensi", "bibas", "illouz", "farouz", "klein" };
            long [] phoneNumber = new long[] { 0767894905, 0584191198, 0512061998, 0648786859, 0589758695 };
            */
            hostingUnitList = new List<HostingUnit>();
            guestRequestList = new List<GuestRequest>();
            orderList = new List<Order>();
        }
        public static string GuestRequestList()
        {
            string str = "";
            string t = "\t";

            foreach (GuestRequest m in guestRequestList)
            {
                
            }
            return str;
        }



    }
}
