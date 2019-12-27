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
        public static List<HostingUnit> hostingUnitsList { get; set; }
        public static List<GuestRequest> guestRequestList { get; set; }
        public static List<Order> ordersList { get; set; }
        public static List<int> listequisertarien { get; set; }

        public DataSource()
        {

            /*string[] privateName = new string[] { "mickael", "itshak", "chmoulik", "hillel", "acher" };
            string[] familyName = new string[] { "balensi", "bibas", "illouz", "farouz", "klein" };

            long [] phoneNumber = new long[] { 0767894905, 0584191198, 0512061998, 0648786859, 0589758695 };
            */
            hostingUnitsList = new List<HostingUnit>();
            guestRequestList = new List<GuestRequest>();
            ordersList = new List<Order>();
        }
    }
}
