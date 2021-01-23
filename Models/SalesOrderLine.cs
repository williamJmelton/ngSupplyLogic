using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SalesOrderLine
    {
        public int SalesOrderOid { get; set; }
        public int LineNum { get; set; }
        public byte Status { get; set; }
        public byte Type { get; set; }
        public string Description { get; set; }
        public int? ItemOid { get; set; }
        public int? OrderedQty { get; set; }
        public byte? Unit { get; set; }
        public decimal? OverrideUnitPrice { get; set; }
        public decimal? OverrideUnitNetCost { get; set; }
        public byte? NoSellingAllowance { get; set; }
        public byte? NoSellingContract { get; set; }
        public byte? NoStampTax { get; set; }
        public byte? NoSalesTax { get; set; }
        public int? PickedQty { get; set; }
        public int? SubstituteItemOid { get; set; }
        public int? SubstitutePickedQty { get; set; }
        public byte? SubstituteUnit { get; set; }
        public decimal? SubstituteOverrideUnitPrice { get; set; }
        public decimal? SubstituteOverrideUnitNetCost { get; set; }
        public int? FreePickedQty { get; set; }
        public decimal? FreeOverrideUnitNetCost { get; set; }
        public int? CreditReasonOid { get; set; }
        public int? TaxStampOid { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }
        public string Message3 { get; set; }
        public string Message4 { get; set; }
        public string Message5 { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitNetCost { get; set; }
        public decimal? ExtendedPrice { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? ExtendedNetCost { get; set; }
        public decimal? ExtendedActualCost { get; set; }
        public decimal? ExtendedStampTax { get; set; }
        public decimal? ExtendedSalesTax { get; set; }
        public decimal? UnitDiscount { get; set; }
        public decimal? ExtendedDiscount { get; set; }
        public decimal? ExtendedPriceDiscount { get; set; }
        public byte? PriceChange { get; set; }
        public byte? Discount { get; set; }
        public byte? FreeItem { get; set; }
        public byte? SubstituteItem { get; set; }
        public int? SellingAllowanceOid { get; set; }
        public int? SellingContractOid { get; set; }
        public int? FreeItemOid { get; set; }
        public int? FreeQty { get; set; }
        public byte? FreeUnit { get; set; }
        public int? CategoryOid { get; set; }
        public int? ClassOid { get; set; }
        public int? ItemInventoryTransOid { get; set; }
        public int? SubstItemInventoryTransOid { get; set; }
        public int? FreeItemInventoryTransOid { get; set; }
        public int? TaxTypeOid { get; set; }
        public int? StateAuthOid { get; set; }
        public decimal? StateAuthTax { get; set; }
        public int? CountyAuthOid { get; set; }
        public decimal? CountyAuthTax { get; set; }
        public int? CityAuthOid { get; set; }
        public decimal? CityAuthTax { get; set; }
        public int? OtherAuthOid { get; set; }
        public decimal? OtherAuthTax { get; set; }
    }
}
