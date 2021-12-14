using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class Payment
    {
        public decimal PaymentId { get; set; }
        public decimal PatientId { get; set; }
        public decimal TreatId { get; set; }
        public decimal DiseaseId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? OriginAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal FinPaymentAmount { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? RevisedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DeleteOrNot { get; set; }

        public virtual NameOfDisease Disease { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Treatment Treat { get; set; }
    }
}
