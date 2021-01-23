using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Contact
    {
        public int ObjId { get; set; }
        public short ParentCid { get; set; }
        public int ParentOid { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public byte? Gender { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneCell { get; set; }
        public string PhonePager { get; set; }
        public string PhoneFax { get; set; }
        public string PhoneData { get; set; }
        public string EmailAddressWork { get; set; }
        public string EmailAddressHome { get; set; }
    }
}
