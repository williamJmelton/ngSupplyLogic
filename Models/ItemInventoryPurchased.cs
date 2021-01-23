using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ItemInventoryPurchased
    {
        public int ObjId { get; set; }
        public int ItemOid { get; set; }
        public int? TaxStampOid { get; set; }
        public DateTime ExpectedReceiptDate { get; set; }
        public int Quantity { get; set; }
        public int? PurchaseOrderOid { get; set; }
        public int? LineNum { get; set; }
    }
}
