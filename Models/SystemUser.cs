using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SystemUser
    {
        public int ObjId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
