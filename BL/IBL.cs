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
        //request
        void addRequest(GuestRequest g);
        void updateRequest();

        //hostingUnit
        void addHostingUnit();
        void deleteHostingUnit();
        void updateHostingUnit();

        //Invitation
        void addInvitation();
        void UpdateInvitation();

        //prints 
        void printAllHostingUnit();
        void printAllOrder();
        void printAllCustomer();
        void printAllBranchesOfBank();
        
        IEnumerable <GuestRequest> GetAllGuestRequests(Func <GuestRequest,bool>predicate=null);
        IEnumerable <HostingUnit> GetAllHostingUnit(Func <HostingUnit,bool>predicate=null);
        IEnumerable <Order> GetAllOrder(Func <Order,bool>predicate=null);

    }
}
