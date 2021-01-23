using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Pospayments
    {
        public int SalesOrderOid { get; set; }
        public int CustomerOid { get; set; }
        public int Line { get; set; }
        public byte? Type { get; set; }
        public decimal? Amount { get; set; }
        public int? Ref { get; set; }
        public string StrRef { get; set; }
    }
}
