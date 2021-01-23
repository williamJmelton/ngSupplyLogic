using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class Shift
    {
        public int ObjId { get; set; }
        public DateTime DateOfShift { get; set; }
        public int SystemUserOid { get; set; }
        public byte Status { get; set; }
        public int NumTransactions { get; set; }
        public DateTime? StartingDateTime { get; set; }
        public DateTime? EndingDateTime { get; set; }
        public decimal? StartingCash { get; set; }
        public decimal? EndingCash { get; set; }
        public int? EndingNumChecks { get; set; }
        public decimal? EndingCheckAmount { get; set; }
        public int? EndingNumCreditCards { get; set; }
        public decimal? EndingCreditCardAmount { get; set; }
        public int? EndingNumOnAccounts { get; set; }
        public decimal? EndingOnAccountAmount { get; set; }
        public decimal? UserEndingCash { get; set; }
        public int? UserEndingNumChecks { get; set; }
        public decimal? UserEndingCheckAmount { get; set; }
        public int? UserEndingNumCreditCards { get; set; }
        public decimal? UserEndingCreditCardAmount { get; set; }
        public int? UserEndingNumOnAccounts { get; set; }
        public decimal? UserEndingOnAccountAmount { get; set; }
    }
}
