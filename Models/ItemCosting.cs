using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ItemCosting
    {
        public int ObjId { get; set; }
        public int ItemOid { get; set; }
        public int TaxStampOid { get; set; }
        public int VendorOid { get; set; }
        public byte? Unit { get; set; }
        public decimal? Cost { get; set; }
        public string VendorItem { get; set; }
    }
}
