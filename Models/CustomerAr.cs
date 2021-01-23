using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class CustomerAr
    {
        public int ObjId { get; set; }
        public int CustomerOid { get; set; }
        public int LastTransNum { get; set; }
        public DateTime? LastOrderDate { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public DateTime? LastStatementDate { get; set; }
        public decimal? TotalOpenInvoices { get; set; }
        public decimal? TotalOpenAdjDebits { get; set; }
        public decimal? TotalOpenCreditMemos { get; set; }
        public decimal? TotalOpenPayments { get; set; }
        public decimal? TotalOpenAdjCredits { get; set; }
        public decimal? BalanceDue { get; set; }
        public string Notes { get; set; }
    }
}
