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
    public class BL_prinp : IBL

    {
        Idal dal = FactoryDal.GetDal();

        public void addRequest(GuestRequest guestreq) {



            checkDate(guestreq);




            dal.addRequest(guestreq);

        }
        public void updateRequest(GuestRequest g) { }
        //hostingUnit
        public void addHostingUnit(HostingUnit h) { }
        public void deleteHostingUnit() { }
        public void updateHostingUnit() { }

        //Invitation
        public void addOrder(Order order)
        {
            List<HostingUnit> l = new List<HostingUnit>(); 
            foreach( HostingUnit n  in GetAllHostingUnit())
                {
                     l.Add(groupUnitByAreaList())   
                }
            

        }
        public void updateOrder(Order order)
        {
            if (checkTransactionSigned(order))
            {
                order.status = StatusOfOrder.MailWasSent;

            }


            dal.updateOrder(order);
        }

        //prints 
        public void printAllHostingUnit() { }
        public void printAllOrder() { }
        public void printAllCustomer() { }
        public void printAllBranchesOfBank() { }
        // New Itshak2
        public int HostingOrder(HostingUnit hosting)
        {
            return hosting.CountOrder;
        }
        public IEnumerable<GuestRequest> getAllGuestRequest(Func<GuestRequest, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.getAllGuestRequest(predicate);
        }
        public IEnumerable<HostingUnit> GetAllHostingUnit(Func<HostingUnit, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.getAllHostingUnit(predicate);
        }
        #region functions
        public void checkDate(GuestRequest request)
        {
            string firstday = request.entryDate.ToString();
            string lastday = request.releaseDate.ToString();
            if (Int32.Parse(firstday.Substring(3, 5)) < Int32.Parse(lastday.Substring(3, 5)))
                throw new Exception("the entrydate is not valuable");
            if (Int32.Parse(firstday.Substring(3, 5)) == Int32.Parse(lastday.Substring(3, 5)) && Int32.Parse(lastday.Substring(0, 2)) - Int32.Parse(firstday.Substring(0, 2)) < 1)
            {
                throw new Exception("the entrydate is not valuable");
            }

        }
        public IEnumerable<HostingUnit> getFreeUnitList(DateTime entryDate, int numberVacationsDays)
        {
            return from n in GetAllHostingUnit()
                   where n.isRoomFree(entryDate, numberVacationsDays) //verifie depuis la datedentre jusquau nombre de jours de fin 
                   select n;
        }



        public bool checkTransactionSigned(Order order)
        {

            GuestRequest req = getAllGuestRequest().FirstOrDefault(x => x.guestRequestKey == order.guestRequestKey);
            return req.transactionSigned;
        }
        public IEnumerable<IGrouping<TypeAreaOfTheCountry, HostingUnit>> groupUnitByAreaList(bool flag)
        {
            return from unit in GetAllHostingUnit()
                   group unit by unit.typeArea;
                   
        }
       /* public IEnumerable<IGrouping<int, Host>>groupHostByNumOfUnitList()
        {
            return from unit in GetAllHostingUnit()
                   group unit by unit.typeArea;
        }*/
        public IEnumerable<IGrouping<TypeAreaOfTheCountry, GuestRequest>> groupRequestByAreaList()
        {
            return from request in getAllGuestRequest()
                   group request by request.area into areagroup;
//                   select new { area = areagroup.Key, request = areagroup };

        }
        public IEnumerable<IGrouping<int, GuestRequest>> groupRequestByNumOfperson()
        {
            return from request in getAllGuestRequest()
                   group request by request.adults + request.children;
        }

        #endregion
    }
}