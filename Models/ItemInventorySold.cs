using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ItemInventorySold
    {
        public int ObjId { get; set; }
        public int ItemOid { get; set; }
        public int? TaxStampOid { get; set; }
        public DateTime RequestedDeliveryDate { get; set; }
        public int Quantity { get; set; }
        public int? SalesOrderOid { get; set; }
        public int? LineNum { get; set; }
    }
}
