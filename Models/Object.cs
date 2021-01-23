using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Object
    {
        public short ClsId { get; set; }
        public int ObjId { get; set; }
        public int ObjInstance { get; set; }
        public DateTime ObjCreated { get; set; }
        public int ObjCreatedByOid { get; set; }
        public DateTime ObjModified { get; set; }
        public int ObjModifiedByOid { get; set; }
        public byte ObjDeleted { get; set; }
        public byte ObjReadOnly { get; set; }
        public byte ObjValid { get; set; }
        public string ObjInvalidMsg { get; set; }
    }
}
