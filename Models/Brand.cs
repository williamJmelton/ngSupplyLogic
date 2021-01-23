using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Brand
    {
        public int ObjId { get; set; }
        public string Name { get; set; }
        public int ManufacturerOid { get; set; }
        public string BrandId { get; set; }
        public string LegalName { get; set; }
        public string BrandType { get; set; }
    }
}
