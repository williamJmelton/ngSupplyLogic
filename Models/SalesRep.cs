using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SalesRep
    {
        public int ObjId { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int? StateOid { get; set; }
        public string ZipCode { get; set; }
    }
}
