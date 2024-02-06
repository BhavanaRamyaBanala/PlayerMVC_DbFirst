using System;
using System.Collections.Generic;

namespace PlayerMVC_DbFirst.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; } = null!;
        public double? Pprice { get; set; }
        public DateTime? PmfDate { get; set; }
    }
}
