using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum CustomerRequirementStatus
    {
        active,
        transactionClosed,
        hasExpired
    }
    public enum StatusOfOrder
    {
        NotYetAddressed,
        anemailwassent,
        closedduetostatusinconsistency,
        Customer,
        ClosesCustomersResponse
    }

    public enum TypeOfHostingUnit
    {
        zimmer,
        apartment,
        roomOfHotel,
        tent
    }

    public enum TypeAreaOfTheCountry
    {
        all,
        north,
        south,
        center,
        jerusalem
    }

    public enum Options
    {
        yes,
        no,
        optional
    }
    
    //rajouter subArea
}
