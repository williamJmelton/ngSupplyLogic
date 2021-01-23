using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Company
    {
        public int ObjId { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateOid { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int TaxJurisdictionOid { get; set; }
        public string DistributorLicenseNum { get; set; }
        public string Pofax { get; set; }
    }
}
