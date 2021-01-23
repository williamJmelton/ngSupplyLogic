using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SalesOrderLineTax
    {
        public int ObjId { get; set; }
        public DateTime DateSold { get; set; }
        public int TaxAuthorityOid { get; set; }
        public int TaxTypeOid { get; set; }
        public int SalesOrderOid { get; set; }
        public int SalesOrderLineNum { get; set; }
        public int CustomerOid { get; set; }
        public int ItemOid { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
