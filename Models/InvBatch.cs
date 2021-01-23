using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class InvBatch
    {
        public int ObjId { get; set; }
        public int BatchId { get; set; }
        public byte BatchStatus { get; set; }
        public int? VendorOid { get; set; }
        public string Invoice { get; set; }
        public byte BatchType { get; set; }
        public DateTime BatchDate { get; set; }
        public string BatchDesc { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalTax { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? DefaultInvTranReasonOid { get; set; }
        public int? SystemUserOid { get; set; }
        public int? UserLineTotal { get; set; }
        public int? UserItemTotal { get; set; }
        public int? SystemLineTotal { get; set; }
        public int? SystemItemTotal { get; set; }
        public byte? CountingBy { get; set; }
        public byte? CountingThe { get; set; }
        public byte? SortBy { get; set; }
        public byte? AuditDetailsCreated { get; set; }
        public int? DefaultTaxStampOid { get; set; }
        public byte? NegInvOnly { get; set; }
    }
}
