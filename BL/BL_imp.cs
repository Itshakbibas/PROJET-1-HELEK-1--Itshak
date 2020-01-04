using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Threading;

namespace BL
{
    public class BL_prinp:IBL

    {
        IDAL dal = FactoryDal.GetDal();

        public  void addRequest(GuestRequest g)   {
            int firstmonth = Int32.Parse(g.EntryDate.Substring(3));
            int firstday = Int32.Parse(g.EntryDate.Substring(0, 2));
            int lastmonth = Int32.Parse(g.ReleaseDate.Substring(3));
            int lastday = Int32.Parse(g.ReleaseDate.Substring(0, 2));
        }
       public void updateRequest(GuestRequest g) { }
       //hostingUnit
       public void addHostingUnit(HostingUnit h) { }
       public void deleteHostingUnit() { }
       public void updateHostingUnit() { }

        //Invitation
        public void addOrder(Order order) { }
        public void UpdateOrder(Order order)         
        {
        
        
        }

        //prints 
        public void printAllHostingUnit() { }
       public void printAllOrder() { }
       public void printAllCustomer() { }
       public void printAllBranchesOfBank() { }
        // New Itshak2
        public int HostingOrder(HostingUnit hosting)
        {
            return hosting.CountOrder;
        }
        public IEnumerable<GuestRequest> GetAllGuestRequests(Func<GuestRequest, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.guestRequestList(predicate);
        }



    }
}
