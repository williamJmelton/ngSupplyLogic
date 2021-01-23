using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class CustomerItemPricing
    {
        public int ObjId { get; set; }
        public int CustomerOid { get; set; }
        public int ItemOid { get; set; }
        public int TaxStampOid { get; set; }
        public byte Unit { get; set; }
        public decimal Price { get; set; }
    }
}
