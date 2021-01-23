using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SellingContract
    {
        public int ObjId { get; set; }
        public int PricingGroupOid { get; set; }
        public short WhatCid { get; set; }
        public int WhatOid { get; set; }
        public byte Priority { get; set; }
        public byte ContractType { get; set; }
        public byte RestrictToUnit { get; set; }
        public byte AmountType { get; set; }
        public decimal Amount { get; set; }
        public byte RoundMethod { get; set; }
        public byte? RoundDigit1 { get; set; }
        public byte? RoundDigit2 { get; set; }
        public byte? CalculateAfterTax { get; set; }
    }
}
