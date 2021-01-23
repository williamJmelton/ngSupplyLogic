using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ArtransAppliedTo
    {
        public int ObjId { get; set; }
        public int CustomerOid { get; set; }
        public int ArdebitTransNum { get; set; }
        public int ArcreditTransNum { get; set; }
        public byte Status { get; set; }
        public DateTime? AppliedDate { get; set; }
        public decimal? AppliedAmount { get; set; }
        public string Notes { get; set; }
    }
}
