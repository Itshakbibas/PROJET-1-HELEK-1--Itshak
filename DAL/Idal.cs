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
    public interface Idal
    {
        //request
        #region add
        void addRequest(GuestRequest guest);
        void addHostingUnit(HostingUnit unit);
        void addOrder(Order order);


        void updateRequest();
        void updateHostingUnit();
        void updateOrder();

        void deleteHostingUnit();


        //get 
        void getAllHostingUnit();
        void getAllOrder();
        void getAllCustomer();
        void getAllBranchesOfBank();

       // IEnumerable<GuestRequest> GetAllGuestRequests(Func<GuestRequest, bool> predicate = null);
        //IEnumerable<HostingUnit> GetAllHostingUnit(Func<HostingUnit, bool> predicate = null);
        //IEnumerable<Order> GetAllOrder(Func<Order, bool> predicate = null);
        //fusion avec master 
    }

}
