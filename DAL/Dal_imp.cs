using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;
using static DS.DataSource;

namespace DAL
{
    public class Dal_imp : Idal
    {
        public void addRequest(GuestRequest g)
        {
            DS.DataSource.guestRequestList.Add(g);
        }
        public void updateRequest( GuestRequest g) 
        { 
               if 
        }
        //hostingUnit
        public void addHostingUnit(HostingUnit hosting ) { }
        public void deleteHostingUnit(HostingUnit hosting) 
        {
            DS.DataSource.hostingUnitsList.Remove(hosting);
         }
        public void updateHostingUnit() { }

        //Invitation
        public void addOrder(Order order ) { }
        public void updateOrder() { }

        //prints 
        public void printAllHostingUnit() { }
        public void printAllOrder() { }
        public void printAllCustomer() { }
        public void printAllBranchesOfBank() { }
        public void getAllHostingUnit() { }
        public void getAllOrder() { }
        public void getAllCustomer() { }
       public  void getAllBranchesOfBank() { }

        //new mickael



    }
}
