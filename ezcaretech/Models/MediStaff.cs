using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class MediStaff
    {
        public MediStaff()
        {
            MediStaffLogins = new HashSet<MediStaffLogin>();
            Treatments = new HashSet<Treatment>();
        }

        public decimal StaffId { get; set; }
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public string MediSubject { get; set; }
        public string PhoneNum { get; set; }
        public string StaffEmail { get; set; }
        public string Position { get; set; }

        public virtual ICollection<MediStaffLogin> MediStaffLogins { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
