using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class UpdateCustomerInfo
    {
        public string CustomerNum { get; set; }
        public string FtpsiteAddress1 { get; set; }
        public string FtpsiteAddress2 { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UpdateInstalled { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? LicenseExpirationDate { get; set; }
    }
}
