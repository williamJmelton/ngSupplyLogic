using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class PaymentTerm
    {
        public int ObjId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? DueDays { get; set; }
        public int? LateDays { get; set; }
        public byte? AllowsDiscount { get; set; }
        public int? DiscountDays { get; set; }
        public decimal? DiscountPercent { get; set; }
    }
}
