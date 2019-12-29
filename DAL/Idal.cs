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
        #endregion
        #region update
        void updateRequest(GuestRequest guest);
        void updateHostingUnit(HostingUnit unit);
        void updateOrder(Order order);
        #endregion
        void deleteHostingUnit(HostingUnit unit);
        #region getters
        List<HostingUnit> getAllHostingUnit();
        List<Order> getAllOrder();
        List<GuestRequest> getAllGuestRequest();
        List<BankBranch> getAllBankBranch();
        #endregion
        // IEnumerable<GuestRequest> GetAllGuestRequests(Func<GuestRequest, bool> predicate = null);
        //IEnumerable<HostingUnit> GetAllHostingUnit(Func<HostingUnit, bool> predicate = null);
        //IEnumerable<Order> GetAllOrder(Func<Order, bool> predicate = null);
        //fusion avec master 
    }

}
