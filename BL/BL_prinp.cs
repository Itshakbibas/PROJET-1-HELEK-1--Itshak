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
    public class BL_prinp:IBL

    {

        Idal dal = FactoryDal.GetDal();



        #region essai 
        void initList()
        {
            GuestRequest request1 = new GuestRequest
            {
                guestRequestKey = 123,               
                entryDate = DateTime.Parse("11.12.88"),
                releaseDate= DateTime.Parse("25.12.88"),
                privateName = "ron",
                familyName= "Bibas",
                mailAddress ="bibasitshak@gmail.com",
                status =CustomerRequirementStatus.transactionClosed,
                jacuzzi = Options.yes,
                garden =  Options.yes,
                childrensAttractions = Options.yes,
                adults=1,
                children=0,


            };

            try
            {
                this.addRequest(request1);
            }
            catch (Exception)
            {
                this.updateRequest(request1);
            }

            GuestRequest request2 = new GuestRequest
            {
                guestRequestKey = 124,
                entryDate = DateTime.Parse("08.10.88"),
                releaseDate = DateTime.Parse("10.12.88"),
                privateName = "mickael",
                familyName = "Balensi",
                mailAddress = "blensimickael@gmail.com",
                status = CustomerRequirementStatus.active,
                jacuzzi = Options.no,
                garden = Options.optional,
                childrensAttractions = Options.yes,
                adults = 2,
                children = 10,


            };

            try
            {
                this.addRequest(request2);
            }
            catch (Exception)
            {
                this.updateRequest(request2);
            }

            GuestRequest request3 = new GuestRequest
            {
                guestRequestKey = 125,
                entryDate = DateTime.Parse("11.12.88"),
                releaseDate = DateTime.Parse("25.12.88"),
                privateName = "Shmuel",
                familyName = "Illouz",
                mailAddress = "IllouzShmuel@gmail.com",
                status = CustomerRequirementStatus.active,
                jacuzzi = Options.no,
                garden = Options.no,
                childrensAttractions = Options.no,
                adults = 2,
                children = 15,


            };

            try
            {
                this.addRequest(request3);
            }
            catch (Exception)
            {
                this.updateRequest(request3);
            }
            HostingUnit s4 = new HostingUnit
            {
                hostingUnitKey = 1234,
                adultPlaces = 2,
                childrenPlaces = 15,
                hostingUnitName = "le palace",
                jacuzzi = true,
                garden = true,
                childrenAttractions = true,
                pool = true,

            };

        }
        #endregion
        #region request 
        public void addRequest(GuestRequest guestreq)
        {
            checkDate(guestreq);
            dal.addRequest(guestreq);

        }
        public void updateRequest(GuestRequest request) { }

        public void printAllCustomer(GuestRequest request) { }
        public IEnumerable<GuestRequest> getAllGuestRequest(Func<GuestRequest, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.getAllGuestRequest(predicate);
        }
        public bool isRoomFree(DateTime entryDate, int numberVacationsDays)
        {

            string beginday = entryDate.ToString();

            int firstDay = Int32.Parse(beginday.Substring(0, 2));
            int firstMonth = Int32.Parse(beginday.Substring(3, 5));

            firstDay -= 1;
            firstMonth -= 1;
            while (numberVacationsDays != 0)
            {
                if (diary[firstMonth, firstDay++])//if one's of the day is already taken 
                    return false;

                if (firstDay == 31) { firstMonth++; firstDay = 0; }//if we got to the end of the month

                numberVacationsDays--;//
            }
            return true;
        }


        #endregion request 
        #region unit 

        //hostingUnit

        public void addHostingUnit(HostingUnit unit) { }
        public void deleteHostingUnit(HostingUnit unit) { }
        public void updateHostingUnit(HostingUnit unit) { }
        public void printAllHostingUnit(HostingUnit unit) { }
        public IEnumerable<HostingUnit> getAllHostingUnit(Func<HostingUnit, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.getAllHostingUnit(predicate);
        }
        public IEnumerable<IGrouping<int, GuestRequest>> groupRequestByNumOfperson()
        {
            return from request in getAllGuestRequest()
                   group request by request.adults + request.children;
        }

        #endregion

        //Invitation
        public void addOrder(Order order)
        {
            List<HostingUnit> l = new List<HostingUnit>();
            foreach (HostingUnit n in getAllHostingUnit())
            {
                l.Add(groupUnitByAreaList())
                }


        }
        public void updateOrder(Order order)
        {
            if (checkTransactionSigned(order))
            {
                order.status = StatusOfOrder.mailWasSent;

            }


            dal.updateOrder(order);
        }

        //prints 
 
        public void printAllOrder(Order order) { }
        public void printAllBranchesOfBank(BankBranch bank) { }
        // New Itshak2
        public int HostingOrder(HostingUnit hosting)
        {
            return hosting.countOrder;
        }

        public IEnumerable<Order> getAllOrder(Func<Order, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.getAllOrder(predicate);
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
            return from n in getAllHostingUnit()
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
            return from unit in getAllHostingUnit()
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


        #endregion
    }
}
