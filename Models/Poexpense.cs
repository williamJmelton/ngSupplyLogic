using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Poexpense
    {
        public int ObjId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Taxable { get; set; }
    }
}
