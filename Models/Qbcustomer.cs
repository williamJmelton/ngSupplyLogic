using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Qbcustomer
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public string BillToAttention { get; set; }
        public string BillToAddressLine1 { get; set; }
        public string BillToAddressLine2 { get; set; }
        public string BillToCity { get; set; }
        public int? BillToStateOid { get; set; }
        public string BillToZipCode { get; set; }
        public string ShipToAttention { get; set; }
        public string ShipToAddressLine1 { get; set; }
        public string ShipToAddressLine2 { get; set; }
        public string ShipToCity { get; set; }
        public int? ShipToStateOid { get; set; }
        public string ShipToZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string Fax { get; set; }
        public string AltPhone { get; set; }
        public string BillTo4 { get; set; }
        public string BillTo5 { get; set; }
        public string ShipTo4 { get; set; }
        public string ShipTo5 { get; set; }
    }
}
