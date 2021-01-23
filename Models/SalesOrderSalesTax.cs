using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SalesOrderSalesTax
    {
        public int SalesOrderOid { get; set; }
        public int TaxAuthOid { get; set; }
        public decimal RatePercentage { get; set; }
        public decimal? PercentageAmount { get; set; }
        public decimal? RateAmount { get; set; }
        public decimal? TaxCollected { get; set; }
    }
}
