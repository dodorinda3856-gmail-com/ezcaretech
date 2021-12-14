using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class Treatment
    {
        public Treatment()
        {
            Payments = new HashSet<Payment>();
        }

        public decimal TreatId { get; set; }
        public decimal PatientId { get; set; }
        public decimal StaffId { get; set; }
        public decimal DiseaseId { get; set; }
        public string TreatDetails { get; set; }
        public string Prescription { get; set; }
        public DateTime TreatDate { get; set; }
        public string TreatStatusVal { get; set; }

        public virtual NameOfDisease Disease { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual MediStaff Staff { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
