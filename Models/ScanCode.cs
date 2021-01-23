using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ScanCode
    {
        public int ObjId { get; set; }
        public string ScanCode1 { get; set; }
        public int ItemOid { get; set; }
        public byte Unit { get; set; }
    }
}
