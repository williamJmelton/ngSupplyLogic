using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class DailyMovementItem
    {
        public int ObjId { get; set; }
        public int ItemOid { get; set; }
        public int CategoryOid { get; set; }
        public int ClassOid { get; set; }
        public int TaxStampOid { get; set; }
        public DateTime Occurred { get; set; }
        public int? BeginQty { get; set; }
        public int? PurchasesQty { get; set; }
        public int? SalesQty { get; set; }
        public int? ReturnsQty { get; set; }
        public int? AuditsQty { get; set; }
        public int? AdjustmentsQty { get; set; }
        public int? OtherQty { get; set; }
        public int? EndQty { get; set; }
        public decimal? BeginActualCost { get; set; }
        public decimal? PurchasesActualCost { get; set; }
        public decimal? SalesActualCost { get; set; }
        public decimal? ReturnsActualCost { get; set; }
        public decimal? AuditsActualCost { get; set; }
        public decimal? AdjustmentsActualCost { get; set; }
        public decimal? OtherActualCost { get; set; }
        public decimal? EndActualCost { get; set; }
        public decimal? BeginNetCost { get; set; }
        public decimal? PurchasesNetCost { get; set; }
        public decimal? SalesNetCost { get; set; }
        public decimal? ReturnsNetCost { get; set; }
        public decimal? AuditsNetCost { get; set; }
        public decimal? AdjustmentsNetCost { get; set; }
        public decimal? OtherNetCost { get; set; }
        public decimal? EndNetCost { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? ReturnsPrice { get; set; }
        public int? StampAdjQty { get; set; }
        public decimal? StampAdjActualCost { get; set; }
        public decimal? StampAdjNetCost { get; set; }
        public DateTime ObjModified { get; set; }
    }
}
