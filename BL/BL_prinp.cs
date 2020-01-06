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
                childrenAttractions = Options.yes,
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
                childrenAttractions = Options.yes,
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
                childrenAttractions = Options.no,
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
        public void addRequest(GuestRequest request)
        {
            checkDate(request);
            dal.addRequest(request);
            addOrder(request);
        }
        public void updateRequest(GuestRequest request) { }

       // public void printAllCustomer(GuestRequest request) { }
        public IEnumerable<GuestRequest> getAllGuestRequest(Func<GuestRequest, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.getAllGuestRequest(predicate);
        }
        public bool isRoomFree(HostingUnit unit,GuestRequest request)
        {

            int firstDay = request.entryDate.Day;
            int firstMonth = request.entryDate.Month;
            int lastDay = request.entryDate.Day;
            int lastMonth = request.entryDate.Month;
            firstDay -= 1;
            firstMonth -= 1;
            while (firstDay != lastDay || firstMonth != lastMonth)
            {
                if (unit.diary[firstMonth, firstDay++])//if one's of the day is already taken 
                    return false;
                if (firstDay == 31) { firstMonth++; firstDay = 0; }//if we got to the end of the month               //
            }
            return true;
        }

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
        #region order
        public void addOrder(GuestRequest request)
        {

             Func<HostingUnit, bool> predicate = unit =>
                 {
                     bool b1 = unit.adultPlaces >= request.adults;
                     bool b2 = unit.childrenPlaces >= request.children;
                     bool b3 = (request.jacuzzi == Options.yes) ? unit.jacuzzi : (request.jacuzzi == Options.no) ? !unit.jacuzzi : true;
                     bool b4 = (request.pool == Options.yes) ? unit.pool : (request.pool == Options.no) ? !unit.pool : true;
                     bool b5 = (request.childrenAttractions == Options.yes) ? unit.childrenAttractions : (request.childrenAttractions == Options.no) ? !unit.childrenAttractions : true;
                     bool b6 = (request.garden == Options.yes) ? unit.garden : (request.garden == Options.no) ? !unit.garden : true;
                     bool b7 = (request.typeArea == TypeAreaOfTheCountry.all) ? true : request.typeArea == unit.typeArea;
                     return b1 && b2 && b3 && b4 && b5 && b6 && b7;
                 };

            foreach (HostingUnit unit in getAllHostingUnit(predicate))
            {
                if (isRoomFree(unit, request))//check if the room is free 
                {
                    dal.addOrder(new Order
                    {
                        hostingUnitKey = unit.hostingUnitKey,
                        guestRequestKey = request.guestRequestKey,
                        status = StatusOfOrder.notYetAddressed,
                        createDate = request.entryDate
                    });
                }
            }

        }
        public void updateOrder(Order order)
        {
            
        }
        public IEnumerable<Order> getAllOrder(Func<Order, bool> predicate = null)
        {
            //if (predicate == null)
            return dal.getAllOrder(predicate);
        }
        //prints 

        //public void printAllOrder(Order order) { }
        #endregion
        // public void printAllBranchesOfBank(BankBranch bank) { }
        // New Itshak2


       

        #region functions
        
        public IEnumerable<HostingUnit> getFreeUnitList(DateTime entrydate, DateTime releasedate)
        {
            GuestRequest request = new GuestRequest
            {
                entryDate = entrydate,
                releaseDate = releasedate,
            };
            return from n in getAllHostingUnit()
                   where isRoomFree(n,request)                          
                   select n;
        }//cest fait 
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
      
        public IEnumerable<IGrouping<TypeAreaOfTheCountry, GuestRequest>> groupRequestByAreaList()
        {
            return from request in getAllGuestRequest()
                   group request by request.area into areagroup;
            //                   select new { area = areagroup.Key, request = areagroup };

        }
        public 

        #endregion
    }
}
