using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class ItemAuth
    {
        public int ObjId { get; set; }
        public string Description { get; set; }
        public int CategoryOid { get; set; }
        public int ClassOid { get; set; }
        public int ItemOid { get; set; }
        public byte Priority { get; set; }
        public int ObjectClassId { get; set; }
        public int ObjectOid { get; set; }
        public byte IsAuth { get; set; }
    }
}
