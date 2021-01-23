using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SellingAllowance
    {
        public int ObjId { get; set; }
        public string Description { get; set; }
        public short WhoCid { get; set; }
        public int WhoOid { get; set; }
        public short WhatCid { get; set; }
        public int WhatOid { get; set; }
        public byte Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte AllowanceType { get; set; }
        public byte RestrictToUnit { get; set; }
        public short? MinimumQuantity1 { get; set; }
        public byte? AmountType1 { get; set; }
        public decimal? Amount1 { get; set; }
        public short? MinimumQuantity2 { get; set; }
        public byte? AmountType2 { get; set; }
        public decimal? Amount2 { get; set; }
        public short? MinimumQuantity3 { get; set; }
        public byte? AmountType3 { get; set; }
        public decimal? Amount3 { get; set; }
        public short? BuyQuantity { get; set; }
        public short? FreeQuantity { get; set; }
        public int? FreeItemOid { get; set; }
        public byte? FreeUnit { get; set; }
        public byte RoundMethod { get; set; }
        public byte? RoundDigit1 { get; set; }
        public byte? RoundDigit2 { get; set; }
    }
}
