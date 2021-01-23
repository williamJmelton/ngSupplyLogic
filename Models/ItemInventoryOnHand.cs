using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ItemInventoryOnHand
    {
        public int ObjId { get; set; }
        public int ItemOid { get; set; }
        public int? TaxStampOid { get; set; }
        public DateTime Received { get; set; }
        public byte UnitReceived { get; set; }
        public decimal UnitActualCost { get; set; }
        public int UnitMultiplier { get; set; }
        public int QuantityReceived { get; set; }
        public int QuantityRemaining { get; set; }
        public int? VendorOid { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public short? TransCid { get; set; }
        public int? TransOid { get; set; }
        public int? LineNum { get; set; }
        public int? ItemInventoryTransOid { get; set; }
    }
}
