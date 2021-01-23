using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngSupplyLogic.Models
{
    public class VendorReportResult
    {
#nullable enable
        public string? Description { get; set; }
        public DateTime? RecievedDate { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? VendorName { get; set; }
    }
}
