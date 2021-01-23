using System;

namespace ngSupplyLogic.Models
{
    public class UnPostedInvoiceResult
    {
        public UnPostedInvoiceResult()
        {
            CalculateProfit();
        }
        public string Name { get; set; }
        public int Num { get; set; }
        public DateTime? InvoicedDate { get; set; }
        public Decimal? TotalPrice { get; set; }
        public int InvoiceObjID { get; set; }
        public Decimal? TotalCost { get; set; }
        public Decimal? TotalProfit { get; set; }
        public string RepFirstName { get; set; }
        public string RepLastName { get; set; }
        public string RepMiddleName { get; set; }
        public Decimal? CalculateProfit()
        {
            TotalProfit = TotalPrice - TotalCost;
            return TotalPrice - TotalCost;
        }
    }
}