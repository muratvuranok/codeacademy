using System;
using System.Collections.Generic;

namespace EFDbFirstApp.Models
{
    public partial class KategorilerView
    {
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
    }
}
