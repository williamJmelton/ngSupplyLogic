using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Uda
    {
        public int ObjId { get; set; }
        public short TypeCid { get; set; }
        public byte Sequence { get; set; }
        public string Name { get; set; }
        public byte Required { get; set; }
        public byte ListOfValues { get; set; }
        public byte TypeOfData { get; set; }
        public decimal? MaxValue { get; set; }
    }
}
