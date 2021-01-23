using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Manufacturer
    {
        public int ObjId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string FeinNum { get; set; }
        public string ManType { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string St { get; set; }
        public string Zipcode { get; set; }
        public string ForMan { get; set; }
        public string Country { get; set; }
    }
}
