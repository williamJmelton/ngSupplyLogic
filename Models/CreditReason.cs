using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class CreditReason
    {
        public int ObjId { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public byte RestockInventory { get; set; }
    }
}
