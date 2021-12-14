using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class PushAlarm
    {
        public decimal AlarmId { get; set; }
        public string AlaramContent { get; set; }
        public DateTime? TransmissionDate { get; set; }
        public string AlarmClassification { get; set; }
    }
}
