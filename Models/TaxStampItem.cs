using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class TaxStampItem
    {
        public int TaxStampOid { get; set; }
        public int TaxStampDenomOid { get; set; }
        public int? Item1Oid { get; set; }
        public int? Item2Oid { get; set; }
        public int? Item3Oid { get; set; }
        public int? Item4Oid { get; set; }
    }
}
