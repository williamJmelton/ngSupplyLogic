using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Category
    {
        public int ObjId { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
        public byte? ShowInSummary { get; set; }
        public string TobCat { get; set; }
        public double? CatDiscount { get; set; }
        public byte AuthItem { get; set; }
    }
}
