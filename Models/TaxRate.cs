using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class TaxRate
    {
        public int ObjId { get; set; }
        public int TaxAuthorityOid { get; set; }
        public short GroupingCid { get; set; }
        public int GroupingOid { get; set; }
        public int TaxTypeOid { get; set; }
        public byte RateType { get; set; }
        public decimal Rate { get; set; }
        public byte? RateUnit { get; set; }
        public byte Priority { get; set; }
        public int? PercentageOf { get; set; }
    }
}
