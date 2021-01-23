using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Class
    {
        public int ObjId { get; set; }
        public int CategoryOid { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
        public byte? Unit1Valid { get; set; }
        public string Unit1Um { get; set; }
        public int? Unit1Multiplier { get; set; }
        public decimal? Unit1Height { get; set; }
        public decimal? Unit1Width { get; set; }
        public decimal? Unit1Depth { get; set; }
        public byte? Unit1SoldByWeight { get; set; }
        public decimal? Unit1Msrp { get; set; }
        public byte? Unit1Sellable { get; set; }
        public byte? Unit2Valid { get; set; }
        public string Unit2Um { get; set; }
        public int? Unit2Multiplier { get; set; }
        public decimal? Unit2Height { get; set; }
        public decimal? Unit2Width { get; set; }
        public decimal? Unit2Depth { get; set; }
        public byte? Unit2SoldByWeight { get; set; }
        public decimal? Unit2Msrp { get; set; }
        public byte? Unit2Sellable { get; set; }
        public byte? Unit3Valid { get; set; }
        public string Unit3Um { get; set; }
        public int? Unit3Multiplier { get; set; }
        public decimal? Unit3Height { get; set; }
        public decimal? Unit3Width { get; set; }
        public decimal? Unit3Depth { get; set; }
        public byte? Unit3SoldByWeight { get; set; }
        public decimal? Unit3Msrp { get; set; }
        public byte? Unit3Sellable { get; set; }
        public byte? Unit4Valid { get; set; }
        public string Unit4Um { get; set; }
        public int? Unit4Multiplier { get; set; }
        public decimal? Unit4Height { get; set; }
        public decimal? Unit4Width { get; set; }
        public decimal? Unit4Depth { get; set; }
        public byte? Unit4SoldByWeight { get; set; }
        public decimal? Unit4Msrp { get; set; }
        public byte? Unit4Sellable { get; set; }
        public byte? StdBuyUnit { get; set; }
        public byte? StdSellUnit { get; set; }
        public decimal? NetCost { get; set; }
        public decimal? ListPrice { get; set; }
        public int? MnfrOid { get; set; }
        public int? BrandOid { get; set; }
        public byte? ComboItem { get; set; }
        public byte? Stampable { get; set; }
        public int? TaxStampDenomOid { get; set; }
        public decimal? Unit1Ounces { get; set; }
        public byte AuthItem { get; set; }
    }
}
