using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class MediProcedure
    {
        public MediProcedure()
        {
            NameOfDiseases = new HashSet<NameOfDisease>();
        }

        public decimal MediProcedureId { get; set; }
        public decimal TreatmentAmount { get; set; }
        public DateTime CreatetionDate { get; set; }
        public DateTime? RevisedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DeleteOrNot { get; set; }

        public virtual ICollection<NameOfDisease> NameOfDiseases { get; set; }
    }
}
