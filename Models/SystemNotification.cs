using System;
using System.Collections.Generic;

namespace ngSupplyLogic.Models
{
    public partial class SystemNotification
    {
        public int ObjId { get; set; }
        public DateTime Started { get; set; }
        public byte Severity { get; set; }
        public int? Num { get; set; }
        public string IdForProgram { get; set; }
        public int? CreatedByUserOid { get; set; }
        public string CreatedBySystemName { get; set; }
        public string CreatedByApplication { get; set; }
        public string CreatedByVersion { get; set; }
        public string CreatedByAppFunction { get; set; }
        public string CreatedByProgramMethod { get; set; }
        public string Message { get; set; }
        public string DetailedMessage { get; set; }
        public string StepsToTake { get; set; }
        public int? DestinationUserOid { get; set; }
        public string DestinationSystemName { get; set; }
        public byte Acknowledged { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public int? AcknowledgedByUserOid { get; set; }
        public decimal? ReAcknowledgeDays { get; set; }
        public string Command { get; set; }
        public byte CommandClearsNotice { get; set; }
        public byte SentToCdr { get; set; }
        public DateTime? ForcedClearDate { get; set; }
    }
}
