using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngSupplyLogic.Models
{
    public class WeeklySalesResult
    {
        public string Name { get; set; }
        public decimal? Qty { get; set; }
        public int Week { get; set; }
    }
}
