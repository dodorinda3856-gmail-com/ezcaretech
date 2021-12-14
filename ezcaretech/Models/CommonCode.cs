using System;
using System.Collections.Generic;

#nullable disable

namespace ezcaretech.Models
{
    public partial class CommonCode
    {
        public decimal Identifier { get; set; }
        public string Name { get; set; }
        public DateTime? RegisDate { get; set; }
        public string DeleteOrNot { get; set; }
        public string CodeName { get; set; }
    }
}
