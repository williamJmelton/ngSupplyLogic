using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Slupdate
    {
        public int ObjId { get; set; }
        public DateTime Started { get; set; }
        public byte Severity { get; set; }
        public int UpdateId { get; set; }
        public string UpdateName { get; set; }
        public byte? Completed { get; set; }
        public DateTime? Finished { get; set; }
    }
}
