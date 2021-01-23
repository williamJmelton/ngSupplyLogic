using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngSupplyLogic.Models
{
    public class DraftOrdersResult
    {
        public DraftOrdersResult()
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
        public string RepLastName { get; set; }
        public string RepMiddleName { get; set; }
        public string RepFirstName { get; set; }
    public Decimal? CalculateProfit()
        {
            TotalProfit = TotalPrice - TotalCost;
            return TotalProfit;
        }
    }
}
