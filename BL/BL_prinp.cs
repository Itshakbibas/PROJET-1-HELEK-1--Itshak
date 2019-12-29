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


        }
        public void updateRequest(GuestRequest g) { }
        //hostingUnit
        public void addHostingUnit(HostingUnit h) { }
        public void deleteHostingUnit() { }
        public void updateHostingUnit() { }

        //Invitation
        public void addOrder(Order order)
        {

            if (freerooms(2,7)==null)
            {
                throw new Exception("sorry there isn't any free room ")
            }

            dal.addOrder(order);



            List<GuestRequest> guestreq = DataSource.guestRequestList;
            List<HostingUnit> hosting = DataSource.hostingUnitsList;
            List<Order> inv = DataSource.ordersList;


        }
        public void updateOrder(Order order)
        {
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
        public IEnumerable<GuestRequest> GetAllGuestRequests(Func<GuestRequest, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.GetAllGuestRequests(predicate);
        }
        public IEnumerable<HostingUnit> GetAllHostingUnit(Func<HostingUnit, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.GetAllHostingUnit(predicate);
        }

        public void checkDate(GuestRequest guestreq)
        {
            string firstday = guestreq.EntryDate.ToString();
            string lastday = guestreq.ReleaseDate.ToString();
            if (Int32.Parse(firstday.Substring(3, 5)) < Int32.Parse(lastday.Substring(3, 5)))
                throw new Exception("the entrydate is not valuable");
            if (Int32.Parse(firstday.Substring(3, 5)) < Int32.Parse(lastday.Substring(3, 5)) && Int32.Parse(firstday.Substring(0, 2)) - Int32.Parse(lastday.Substring(0, 2)) < 2)
            {
                throw new Exception("the entrydate is not valuable");
            }
        }
        public IEnumerable<HostingUnit> freerooms(int EntryDate,int ReleaseDate)
        {
            return from n in GetAllHostingUnit()
                   where n.IsRoomFree(EntryDate, ReleaseDate) 
                   select n;
        }
    }
