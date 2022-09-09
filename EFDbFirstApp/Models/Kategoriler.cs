using System;
using System.Collections.Generic;

namespace EFDbFirstApp.Models
{
    public partial class Kategoriler
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
    }
}
