using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class NameOfDisease
    {
        public NameOfDisease()
        {
            Payments = new HashSet<Payment>();
            Treatments = new HashSet<Treatment>();
        }

        public decimal DiseaseId { get; set; }
        public decimal MediProcedureId { get; set; }
        public string DiseaseName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? RevisedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DeleteOrNot { get; set; }

        public virtual MediProcedure MediProcedure { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
