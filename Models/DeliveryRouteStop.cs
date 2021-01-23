using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class DeliveryRouteStop
    {
        public int ObjId { get; set; }
        public int DeliveryRouteOid { get; set; }
        public int CustomerOid { get; set; }
        public int StopNumber { get; set; }
    }
}
