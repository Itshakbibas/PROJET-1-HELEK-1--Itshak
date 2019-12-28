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
        public void addRequest(GuestRequest request)
        {
            DS.DataSource.guestRequestList.Add(request);
        }
        public void addHostingUnit(HostingUnit hosting)
        {
            DS.DataSource.hostingUnitsList.Add(hosting);
        }
        public void addOrder(Order order) {
            DS.DataSource.ordersList.Add(order);
        }
        public void updateRequest(GuestRequest request) {
            request.Status = CustomerRequirementStatus.transactionClosed;
        }
        //hostingUnit
        public void deleteHostingUnit() { }

        public void updateHostingUnit() { }

        //Invitation
        public void updateOrder(Order order) {
        }

        //prints 
        public void printAllHostingUnit() { }
        public void printAllOrder() { }
        public void printAllCustomer() { }
        public void printAllBranchesOfBank() { }
        public void getAllHostingUnit() { }
        public void getAllOrder() { }
        public void getAllCustomer() { }
       public  void getAllBranchesOfBank() { }





    }
}
