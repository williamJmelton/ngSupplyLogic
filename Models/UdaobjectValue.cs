using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class UdaobjectValue
    {
        public int ObjId { get; set; }
        public int Udaoid { get; set; }
        public int ObjectOid { get; set; }
        public int? UdavalueOid { get; set; }
        public string Udavalue { get; set; }
        public short? TypeCid { get; set; }
    }
}
