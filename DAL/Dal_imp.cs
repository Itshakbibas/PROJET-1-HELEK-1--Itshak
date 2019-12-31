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
            if (DataSource.guestRequestList.Exists(x => x.ID == request.ID))//check if the mispar teoudat zeout is present 
                throw new Exception("your  ID is already present ");

            Configuration.GuestRequestCount++;//to advance the Static GuestRequestKey
        
            
            DataSource.guestRequestList.Add(request);
        }
        public void addHostingUnit(HostingUnit unit)
        {


            Configuration.HostingUnitCount++;
            DS.DataSource.hostingUnitsList.Add(unit);
        }
        public void addOrder(Order order) {
           

            List<GuestRequest> guestreq = DataSource.guestRequestList;
            List<HostingUnit> hosting = DataSource.hostingUnitsList;
            List<Order> inv = DataSource.ordersList;

             DS.DataSource.ordersList.Add(order);
        }



        public void updateRequest(GuestRequest request) {
            request.Status = CustomerRequirementStatus.transactionClosed;
        }

        public void updateHostingUnit(HostingUnit unit) { }

        public void updateOrder(Order order)
        {
            List<GuestRequest> l = DataSource.guestRequestList;
            if (l.Exists(x => x.GuestRequestKey == order.GuestRequestKey))
                
                    
                    
                    //Order O = l.Find(x => x.GuestRequestKey == order.GuestRequestKey);

        }


        //hostingUnit

        //creer list de bank branch qq part
       


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
            return from n in DataSource.ordersList
                   where (predicate(n))
                   select n;

        }
        public IEnumerable<HostingUnit> GetAllHostingUnit(Func<HostingUnit, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.hostingUnitsList.AsEnumerable();
            

             return from n in DataSource.hostingUnitsList
                   where (predicate(n))
                   select n;

        }
        public IEnumerable<BankBranch> bankBranchList()
           List<BankBranch> bankbranchList = new List<BankBranch>();
             



            List<BankBranch> snifBankList =


    }
}
