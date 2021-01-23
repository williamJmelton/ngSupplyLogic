using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class TaxJurisdictionType
    {
        public int ObjId { get; set; }
        public int TaxJurisdictionOid { get; set; }
        public int TaxTypeOid { get; set; }
        public byte StateApplies { get; set; }
        public byte CountyApplies { get; set; }
        public byte CityApplies { get; set; }
        public byte OtherApplies { get; set; }
    }
}
