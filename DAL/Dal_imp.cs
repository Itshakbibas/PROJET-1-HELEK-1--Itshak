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
        public void addHostingUnit(HostingUnit unit)
        {
            DS.DataSource.hostingUnitsList.Add(unit);
        }
        public void addOrder(Order order) {
            DS.DataSource.ordersList.Add(order);
        }



        public void updateRequest(GuestRequest request) {
            request.Status = CustomerRequirementStatus.transactionClosed;
        }
        public void updateHostingUnit(HostingUnit unit) { }

        public void updateOrder(Order order)
        {
        }


        //hostingUnit
        public void deleteHostingUnit(HostingUnit unit) {
            DS.DataSource.hostingUnitsList.Remove(unit);
        }
        //prints 
        public List<HostingUnit> getAllHostingUnit() {
            return DS.DataSource.hostingUnitsList;
        }
        public List<Order> getAllOrder() {
            return DS.DataSource.ordersList;

        }
        public List<GuestRequest> getAllGuestRequest() {
            return DS.DataSource.guestRequestList;
        }
        //creer list de bank branch qq part
        public List<BankBranch> getAllBankBranch() {
        return DS.DataSource.}





    }
}
