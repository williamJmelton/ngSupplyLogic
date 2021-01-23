using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class CustomerSalesOrderMessage
    {
        public int CustomerOid { get; set; }
        public int Num { get; set; }
        public string Message { get; set; }
        public byte Placement { get; set; }
        public byte ShowOnPickList { get; set; }
        public byte ShowOnInvoice { get; set; }
        public byte DisplayInBold { get; set; }
    }
}
