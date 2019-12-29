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
            List<GuestRequest> guestreq = DataSource.guestRequestList;
            List<HostingUnit> hosting = DataSource.hostingUnitsList;
            List<Order> inv = DataSource.ordersList;
            //List<> guestreq = DataSource.guestRequestList;
            if (!)




            // DS.DataSource.ordersList.Add(order);
        }



        public void updateRequest(GuestRequest request) {
            request.Status = CustomerRequirementStatus.transactionClosed;
        }

        public void updateHostingUnit(HostingUnit unit) { }

        public void updateOrder(Order order)
        {
            List<Order> l = DataSource.ordersList;
            if (l.Exists(x => x.GuestRequestKey == order.GuestRequestKey))
                Order O = l.Find(x => x.GuestRequestKey == order.GuestRequestKey);

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


        public IEnumerable<GuestRequest> GetAllGuestRequests(Func<GuestRequest, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.guestRequestList.AsEnumerable();
            return from n in DataSource.guestRequestList
                   where (predicate(n))
                   select n;

        }
        public IEnumerable<Order> GetAllOrder(Func<Order, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.ordersList.AsEnumerable();
            return DataSource.ordersList.Where(predicate);

        }
        public IEnumerable<HostingUnit> GetAllHostingUnit(Func<HostingUnit, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.hostingUnitsList.AsEnumerable();
            return DataSource.hostingUnitsList.Where(predicate);

            /* return from n in DataSource.hostingUnitsList
                   where (predicate(n))
                   select n;*/

        }

    }
}
