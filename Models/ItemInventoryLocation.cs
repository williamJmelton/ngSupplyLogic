using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ItemInventoryLocation
    {
        public int ObjId { get; set; }
        public int ItemOid { get; set; }
        public int TaxStampOid { get; set; }
        public string SlotLocation { get; set; }
    }
}
