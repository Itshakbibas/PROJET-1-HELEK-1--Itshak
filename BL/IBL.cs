using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public interface IBL
    {
        #region add
        void addRequest(GuestRequest request);
        void addHostingUnit(HostingUnit unit);
        void addOrder(Order order);

        #endregion

        void updateRequest(GuestRequest request);

        //hostingUnit
     void addHostingUnit(HostingUnit h);
        void deleteHostingUnit(HostingUnit h);
        void updateHostingUnit(HostingUnit h);

        //Invitation
        void UpdateOrder(Order order);

        //prints 
        void printAllHostingUnit(HostingUnit h);
        void printAllOrder(HostingUnit h);
        void printAllCustomer();
        void printAllBranchesOfBank();

        IEnumerable <GuestRequest> GetAllGuestRequests(Func <GuestRequest,bool>predicate=null);
        IEnumerable <HostingUnit> GetAllHostingUnit(Func <HostingUnit,bool>predicate=null);
        IEnumerable <Order> GetAllOrder(Func <Order,bool>predicate=null);
        

    }
}
