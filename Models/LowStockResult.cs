using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngSupplyLogic.Models
{
    public class LowStockResult
    {
        public string Name { get; set; }
        public bool needsOrdering { get; set; }
#nullable enable
        public WeeklySalesResult? prevWeekSalesQty { get; set; }
        public decimal? onHandQty { get; set; }

    }
}
