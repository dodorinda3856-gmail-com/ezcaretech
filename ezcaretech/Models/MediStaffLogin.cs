using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class MediStaffLogin
    {
        public string StaffLoginId { get; set; }
        public decimal StaffId { get; set; }
        public string StaffLoginPw { get; set; }

        public virtual MediStaff Staff { get; set; }
    }
}
