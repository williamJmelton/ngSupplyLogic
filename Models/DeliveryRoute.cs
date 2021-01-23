using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class DeliveryRoute
    {
        public int ObjId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte? DeliveryDayOfWeek { get; set; }
    }
}
