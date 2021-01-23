using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class TaxStamp
    {
        public int ObjId { get; set; }
        public string Description { get; set; }
        public int? TaxStampItem1Oid { get; set; }
        public int? TaxStampItem2Oid { get; set; }
        public int? TaxStampItem3Oid { get; set; }
        public int? TaxStampItem4Oid { get; set; }
    }
}
