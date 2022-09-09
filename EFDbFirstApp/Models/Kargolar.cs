using System;
using System.Collections.Generic;

namespace EFDbFirstApp.Models
{
    public partial class Kargolar
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}
