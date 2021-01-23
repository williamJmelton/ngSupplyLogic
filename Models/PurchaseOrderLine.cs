using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class PurchaseOrderLine
    {
        public int PurchaseOrderOid { get; set; }
        public int LineNum { get; set; }
        public byte Status { get; set; }
        public byte Type { get; set; }
        public string Description { get; set; }
        public int? ItemOid { get; set; }
        public int? OrderedQty { get; set; }
        public byte? Unit { get; set; }
        public decimal? OverrideUnitPrice { get; set; }
        public decimal? OverrideUnitNetCost { get; set; }
        public byte? NoStampTax { get; set; }
        public byte? NoSalesTax { get; set; }
        public int? ReceivedQty { get; set; }
        public int? FreeReceivedQty { get; set; }
        public decimal? FreeOverrideUnitNetCost { get; set; }
        public int? PoreasonOid { get; set; }
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
        public int? BuyingAllowanceOid { get; set; }
        public int? FreeItemOid { get; set; }
        public int? FreeQty { get; set; }
        public byte? FreeUnit { get; set; }
        public int? TotalQuantity { get; set; }
        public int? TotalOrderedQuantity { get; set; }
        public int? CategoryOid { get; set; }
        public int? ClassOid { get; set; }
        public int? ItemInventoryTransOid { get; set; }
        public byte UpdateInventory { get; set; }
        public int? TaxStampOid { get; set; }
        public string Message1 { get; set; }
    }
}
