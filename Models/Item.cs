using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Item
    {
        public int ObjId { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryOid { get; set; }
        public int ClassOid { get; set; }
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
        public byte SellingStatus { get; set; }
        public byte BuyingStatus { get; set; }
        public byte? CigReport { get; set; }
        public byte? ComboItem { get; set; }
        public byte? ComboReceivedAs { get; set; }
        public byte? ComboPickedAs { get; set; }
        public byte? ComboPricedAs { get; set; }
        public byte? ComboReportedAs { get; set; }
        public int? MnfrOid { get; set; }
        public string MnfrPartNum { get; set; }
        public int? BrandOid { get; set; }
        public string SlotLocation { get; set; }
        public string PictureFileName { get; set; }
        public int? SubstituteItemOid { get; set; }
        public decimal? LastReceivedCost { get; set; }
        public decimal? LastReceivedUnit { get; set; }
        public int? StdSellUnitFactor { get; set; }
        public byte? Stampable { get; set; }
        public byte? PrintComboComponents { get; set; }
        public byte? DisableMultiplier { get; set; }
        public int? TaxStampDenomOid { get; set; }
        public decimal? Unit1Ounces { get; set; }
        public byte AuthItem { get; set; }
    }
}
