using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ReportFormat
    {
        public int ObjId { get; set; }
        public string Format { get; set; }
        public string Description { get; set; }
        public string DistributorSiteId { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactEmail { get; set; }
        public int ReportPeriod { get; set; }
        public DateTime? LastEndDate { get; set; }
        public int? FormatSpec { get; set; }
    }
}
