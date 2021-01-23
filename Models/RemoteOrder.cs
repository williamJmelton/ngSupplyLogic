using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class RemoteOrder
    {
        public int ObjId { get; set; }
        public string Srnum { get; set; }
        public string Zeros { get; set; }
        public string CustNum { get; set; }
        public string ShipTo { get; set; }
        public string Message { get; set; }
        public string Created { get; set; }
        public string Route { get; set; }
        public string Po { get; set; }
        public string Source { get; set; }
        public int? SalesOrderOid { get; set; }
    }
}
