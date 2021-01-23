using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ComboItemComponent
    {
        public int ObjId { get; set; }
        public int ComboItemOid { get; set; }
        public int ComponentItemOid { get; set; }
        public byte ComponentUnit { get; set; }
        public int ComponentQuantity { get; set; }
    }
}
