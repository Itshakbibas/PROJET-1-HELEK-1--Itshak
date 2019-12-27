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
       public  void addRequest(GuestRequest g)   {
            
        }
       public void updateRequest(GuestRequest g) { }
       //hostingUnit
       public void addHostingUnit(HostingUnit h) { }
       public void deleteHostingUnit() { }
       public void updateHostingUnit() { }

        //Invitation
        public void addOrder(Order order) { }
        public void UpdateOrder(Order order) { }

        //prints 
        public void printAllHostingUnit() { }
       public void printAllOrder() { }
       public void printAllCustomer() { }
       public void printAllBranchesOfBank() { }


    }
}
