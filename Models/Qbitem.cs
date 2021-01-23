using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Qbitem
    {
        public int CatNo { get; set; }
        public string Category { get; set; }
        public int ClassNo { get; set; }
        public string Class { get; set; }
        public string Unit1Um { get; set; }
        public string Unit2Um { get; set; }
        public string Unit3Um { get; set; }
        public int? Unit2Multiplier { get; set; }
        public int? Unit3Multiplier { get; set; }
        public decimal? NetCost { get; set; }
        public decimal? ListPrice { get; set; }
        public int ItemNum { get; set; }
        public string Item { get; set; }
        public string Upc { get; set; }
    }
}
