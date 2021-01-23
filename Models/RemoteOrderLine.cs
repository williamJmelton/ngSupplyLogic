using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class RemoteOrderLine
    {
        public int RemoteOrderOid { get; set; }
        public int LineNum { get; set; }
        public string Upc { get; set; }
        public string Qty { get; set; }
        public string Sign { get; set; }
        public string Unit { get; set; }
        public string Zeros { get; set; }
        public string Price { get; set; }
        public string Cr { get; set; }
    }
}
