using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class Waiting
    {
        public decimal WatingId { get; set; }
        public decimal PatientId { get; set; }
        public DateTime RequestToWait { get; set; }
        public string Requirements { get; set; }
        public string ReserveStatusVal { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
