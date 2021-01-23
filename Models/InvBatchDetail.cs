using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class InvBatchDetail
    {
        public int ObjId { get; set; }
        public int BatchOid { get; set; }
        public int LineNum { get; set; }
        public byte SubLineNum { get; set; }
        public byte Status { get; set; }
        public int? ItemOid { get; set; }
        public byte? Unit { get; set; }
        public int? Qty { get; set; }
        public int? Unit1Qty { get; set; }
        public int? Unit2Qty { get; set; }
        public int? Unit3Qty { get; set; }
        public int? Unit4Qty { get; set; }
        public decimal? TotalActualCost { get; set; }
        public decimal? TotalNetCost { get; set; }
        public int? InvTranReasonOid { get; set; }
        public int? PrePostQtyOnHand { get; set; }
        public int? TaxStampOid { get; set; }
    }
}
