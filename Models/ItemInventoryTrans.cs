using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ItemInventoryTrans
    {
        public int ObjId { get; set; }
        public int ItemOid { get; set; }
        public int? TaxStampOid { get; set; }
        public DateTime? Occurred { get; set; }
        public int SystemUserOid { get; set; }
        public short TransCid { get; set; }
        public int TransOid { get; set; }
        public int? LineNum { get; set; }
        public int? CategoryOid { get; set; }
        public int? ClassOid { get; set; }
        public int? CustomerOid { get; set; }
        public int? SalesRepOid { get; set; }
        public byte Type { get; set; }
        public byte Status { get; set; }
        public byte Unit { get; set; }
        public int Quantity { get; set; }
        public decimal TotalActualCost { get; set; }
        public decimal TotalNetCost { get; set; }
        public decimal TotalPrice { get; set; }
        public int? CreditReasonOid { get; set; }
        public byte ImmedPostFlag { get; set; }
        public byte DailyPostFlag { get; set; }
        public byte? ItemType { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
