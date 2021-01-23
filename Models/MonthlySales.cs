using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class MonthlySales
    {
        public int ObjId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int CustomerOid { get; set; }
        public int ItemOid { get; set; }
        public int CategoryOid { get; set; }
        public int ClassOid { get; set; }
        public int SalesRepOid { get; set; }
        public int SalesUnit1Qty { get; set; }
        public int SalesUnit2Qty { get; set; }
        public int SalesUnit3Qty { get; set; }
        public int SalesUnit4Qty { get; set; }
        public int ReturnsUnit1Qty { get; set; }
        public int ReturnsUnit2Qty { get; set; }
        public int ReturnsUnit3Qty { get; set; }
        public int ReturnsUnit4Qty { get; set; }
        public int LostSalesUnit1Qty { get; set; }
        public int LostSalesUnit2Qty { get; set; }
        public int LostSalesUnit3Qty { get; set; }
        public int LostSalesUnit4Qty { get; set; }
        public decimal SalesActualCost { get; set; }
        public decimal ReturnsActualCost { get; set; }
        public decimal SalesNetCost { get; set; }
        public decimal ReturnsNetCost { get; set; }
        public decimal LostSalesNetCost { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal ReturnsPrice { get; set; }
        public decimal LostSalesListPrice { get; set; }
        public int TaxStampOid { get; set; }
        public int? BrandOid { get; set; }
        public int? ManufacturerOid { get; set; }
        public decimal? SalesQty { get; set; }
        public decimal? ReturnsQty { get; set; }
        public decimal? LostSalesQty { get; set; }
        public DateTime ObjModified { get; set; }
    }
}
