using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ArResult
    {
        public int ObjId { get; set; }
        public int CustomerOid { get; set; }
        public int TransNum { get; set; }
        public byte Source { get; set; }
        public DateTime EntryDate { get; set; }
        public byte Type { get; set; }
        public DateTime TransDate { get; set; }
        public byte Status { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal UnappliedAmount { get; set; }
        public int? SalesOrderOid { get; set; }
        public int? InvoiceNum { get; set; }
        public int? PaymentTermOid { get; set; }
        public DateTime? DiscountDate { get; set; }
        public decimal? DiscountAmountAvailable { get; set; }
        public decimal? DiscountAmountTaken { get; set; }
        public byte? PaymentType { get; set; }
        public byte? PaymentStatus { get; set; }
        public int? CheckNum { get; set; }
        public int? AradjustmentReasonOid { get; set; }
        public string Notes { get; set; }
        public string StrRef { get; set; }
        public string CustomerName { get; set; }
        public int CustomerNumber { get; set; }
    }
}
