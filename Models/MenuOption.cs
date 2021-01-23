using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class MenuOption
    {
        public int ObjId { get; set; }
        public int ParentMenuOid { get; set; }
        public byte MenuSequence { get; set; }
        public byte OptionType { get; set; }
        public string Name { get; set; }
        public int? FunctionOid { get; set; }
    }
}
