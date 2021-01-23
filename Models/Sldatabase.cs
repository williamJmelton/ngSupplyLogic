using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Sldatabase
    {
        public int ObjId { get; set; }
        public string Description { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public int Archive { get; set; }
        public int? Dbversion { get; set; }
    }
}
