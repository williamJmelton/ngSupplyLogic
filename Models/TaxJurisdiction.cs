using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class TaxJurisdiction
    {
        public int ObjId { get; set; }
        public string Description { get; set; }
        public int? StateTaxAuthOid { get; set; }
        public int? CountyTaxAuthOid { get; set; }
        public int? CityTaxAuthOid { get; set; }
        public int? OtherTaxAuthOid { get; set; }
        public int? TaxStampOid { get; set; }
    }
}
