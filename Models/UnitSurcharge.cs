using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class UnitSurcharge
    {
        public int ObjId { get; set; }
        public int PricingGroupOid { get; set; }
        public short WhatCid { get; set; }
        public int WhatOid { get; set; }
        public byte Priority { get; set; }
        public byte AmountType { get; set; }
        public decimal? Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
        public decimal? Amount3 { get; set; }
        public decimal? Amount4 { get; set; }
    }
}
