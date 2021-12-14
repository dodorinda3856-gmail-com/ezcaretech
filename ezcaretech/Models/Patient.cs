using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Payments = new HashSet<Payment>();
            Treatments = new HashSet<Treatment>();
            Waitings = new HashSet<Waiting>();
        }

        public decimal PatientId { get; set; }
        public string ResidentRegistNum { get; set; }
        public string Address { get; set; }
        public string PatientName { get; set; }
        public string PhoneNum { get; set; }
        public DateTime RegistDate { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string PatientStatusVal { get; set; }
        public string AgreeOfAlarm { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
        public virtual ICollection<Waiting> Waitings { get; set; }
    }
}
